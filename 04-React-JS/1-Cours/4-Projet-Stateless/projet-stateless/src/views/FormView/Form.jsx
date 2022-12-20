import { React, useState } from 'react';
import './Form.css';

const Form = () => {

    const [nom, setNom] = useState("");
    const [prenom, setPrenom] = useState("");
    const [email, setEmail] = useState("");
    const [type, setType] = useState("");
    const [text, setText] = useState("");

    function handleSubmit(e) {
        e.preventDefault()
    }

    return (
        <div className='container'>
            <h1>Les formulaires en React - Form.jsx</h1>
            <div className="card">
                <form onSubmit={handleSubmit}>
                    <div className="form-control">
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name='nom' onChange={(e) => setNom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name='prenom' onChange={(e) => setPrenom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email">Email : </label>
                            <input type="text" name='email' onChange={(e) => setEmail(e.target.value)} />
                        </div>
                        <select className='form-select' onChange={(e) => setType(e.target.value)}>
                            <option selected disabled>Choisissez votre type de demande</option>
                            {/* selected disabled => Pour l'afficher par défaut, sans pouvoir le cliquer */}
                            <option value="1">Renseignements à propos d'une formation</option>
                            <option value="2">Demande de rendez-vous</option>
                            <option value="3">Autres demandes...</option>
                        </select>
                        <div className="mb-3">
                            <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                            <textarea className='form-control' name="FormTextArea" cols="30" rows="5" onChange={(e) => setText(e.target.value)}></textarea>
                        </div>
                        <button type='submit' className='btn btn-secondary form-control'>Valider</button>
                    </div>
                </form>
            </div>


            <div className="card">
                <div className="form-control">
                    <div className="mb-3">
                        <label htmlFor="nom">Nom : </label>
                        <input type="text" name='nom' placeholder={nom}/>
                    </div>
                    <div className="mb-3">
                        <label htmlFor="prenom">Prénom : </label>
                        <input type="text" name='prenom' placeholder={prenom} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="email">Email : </label>
                        <input type="text" name='email' placeholder={email} />
                    </div>
                    <select className='form-select' onChange={(e) => setType(e.target.value)}>
                        <option selected disabled>Choisissez votre type de demande</option>
                        {/* selected disabled => Pour l'afficher par défaut, sans pouvoir le cliquer */}
                        <option value="1">Renseignements à propos d'une formation</option>
                        <option value="2">Demande de rendez-vous</option>
                        <option value="3">Autres demandes...</option>
                    </select>
                    <div className="mb-3">
                        <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                        <textarea className='form-control' name="FormTextArea" cols="30" rows="5" placeholder={text}></textarea>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Form;