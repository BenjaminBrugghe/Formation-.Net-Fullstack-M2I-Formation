import React from 'react';
import './List.css';

const List = () => {
    return (
        <div className='tableau'>
            <h2>Liste de contacts</h2>
            <table>
                <thead id='Infos'>
                    <th>#</th>
                    <th>Nom</th>
                    <th>Prenom</th>
                    <th>Email</th>
                    <th>Phone</th>
                </thead>
            </table>
        </div>

    );
};

export default List;