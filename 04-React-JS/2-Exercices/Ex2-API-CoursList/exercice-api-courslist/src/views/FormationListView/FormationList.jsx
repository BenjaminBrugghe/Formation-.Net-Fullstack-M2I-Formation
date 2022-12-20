import { React, useState } from 'react';
import './FormationList.css';
import Category from '../../components/CategoryComponents/Category';
import FormationCard from '../../components/FormationCardComponent/FormationCard';
import Cart from '../../components/CartComponent/Cart';

// import { coursList } from '../../datas/CoursList';
import { getCoursApi, searchCoursApi } from '../../ApiService';

const FormationList = ({ cart, updateCart }) => {

    // Déclaration d'un state
    const [coursList, setCoursList] = useState();
    const [activeCategory, setActiveCategory] = useState('');


    const categoryList = coursList ? coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category), []
    ) : [];

    function FetchData() {
        getCoursApi().then((data) => setCoursList(data))
    }

    function SearchData(id) {
        let response = [];
        searchCoursApi(id).then((data) => {
            response.push(data)
        })
        setCoursList(response)
    }

    function AddToCart(name, price) {
        // Rechercher si la formation est déjà présente dans notre panier
        const formationAdded = cart.find((cours) => cours.name === name);
        // Vérifier si la formationn est déjà présente
        if (formationAdded) {
            const filteredCart = cart.filter(
                (cours) => cours.name !== name
            )
            // Update de la quantité
            updateCart([...filteredCart, { name, price, amount: formationAdded.amount + 1 }])
        }
        else {
            updateCart([...cart, { name, price, amount: 1 }])
        }
        alert(`La formation ${name} a bien été ajoutée !`);
    }

    return coursList ? (
        <div className='formation-list'>
            <h1>This is FormationList.jsx</h1>
            <div>
                <div className="row">
                    <div className="col-8">
                        <Category
                            categoryList={categoryList}
                            activeCategory={activeCategory}
                            setActiveCategory={setActiveCategory}
                        />
                    </div>
                    <div className="col-2 paddingTop">
                        <Cart cart={cart} updateCart={updateCart} />
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList? coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?
                        <div key={index} onClick={() => AddToCart(cours.name, cours.price)} >
                            <FormationCard
                                name={cours.name}
                                logo={cours.logo}
                                category={cours.category}
                                difficulte={cours.difficulte}
                                price={cours.price}
                                index={index}
                            />
                        </div>
                        :
                        null
                ) : [] }
            </div>
        </div>
    ) :
        (
            <div>
                <button onClick={() => FetchData()}>Charger les données depuis l'API</button>
                <button onClick={() => SearchData()}>Chercher la formation par id</button>
            </div>
        );
};

export default FormationList;