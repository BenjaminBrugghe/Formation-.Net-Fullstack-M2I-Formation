import { React, useState } from 'react';
import { addCoursAPI } from '../../ApiService';
import './Form.css';

const Form = () => {

    const [category, setcategory] = useState("");
    const [name, setname] = useState("");
    const [difficulte, setdifficulte] = useState("");
    const [price, setprice] = useState("");

    function handleSubmit(e) {
        e.preventDefault();
        const newCours = {
            Category : category,
            Name : name,
            Difficulte : difficulte,
            Price : price
        }
        addCoursAPI(newCours);
    }

    return (
        <div className='container'>
            <h1>Les formulaires en React - Form.jsx</h1>
            <div className="card">
                <form onSubmit={handleSubmit}>
                    <div className="form-control">
                        <div className="mb-3">
                            <label htmlFor="category">category : </label>
                            <input type="text" name='category' onChange={(e) => setcategory(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="name">name : </label>
                            <input type="text" name='name' onChange={(e) => setname(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="difficulte">difficulte : </label>
                            <input type="text" name='difficulte' onChange={(e) => setdifficulte(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="price">price : </label>
                            <input type="text" name='price' onChange={(e) => setprice(e.target.value)} />
                        </div>

                        <button type='submit' className='btn btn-secondary form-control'>Valider</button>
                    </div>
                </form>
            </div>
        </div>
    );
};

export default Form;