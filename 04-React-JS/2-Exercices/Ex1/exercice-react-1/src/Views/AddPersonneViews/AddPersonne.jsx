import { React, useState } from 'react';
import './AddPersonne.css';

const AddPersonne = ( { AddPersonne, updateInfos}) => {

    const [nom, setNom] = useState("");
    const [prenom, setPrenom] = useState("");
    const [email, setEmail] = useState("");
    const [phone, setPhone] = useState("");

    function handleSubmit(e) {
        e.preventDefault()
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <div className='form-control'>
                    <div className='mb-3'>
                        <label htmlFor="nom">Nom :</label>
                        <input type="text" name='nom' onChange={(e) => setNom(e.target.value)} />
                    </div>
                    <div className='mb-3'>
                        <label htmlFor="prenom">Prénom :</label>
                        <input type="text" name='prenom' onChange={(e) => setPrenom(e.target.value)} />
                    </div>
                    <div className='mb-3'>
                        <label htmlFor="email">Email :</label>
                        <input type="text" name='email' onChange={(e) => setEmail(e.target.value)} />
                    </div>
                    <div className='mb-3'>
                        <label htmlFor="phone">Phone N° :</label>
                        <input type="text" name='phone' onChange={(e) => setPhone(e.target.value)} />
                    </div>
                    <button type='submit' className='btn btn-secondary'>Valider</button>
                </div>
            </form>
        </div>
    );
};

export default AddPersonne;