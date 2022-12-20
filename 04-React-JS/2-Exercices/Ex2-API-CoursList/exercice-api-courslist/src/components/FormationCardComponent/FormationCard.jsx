import React from 'react';
import CareScale from '../CareScaleComponent/CareScale';
import './FormationCard.css';

const FormationCard = (cours, index) => {
    console.log(cours.name);
    return (
        <div className='card' key={index}>
            <div className="card-title">
                {cours.name}
            </div>
            <div>
                <img className='img' src={cours.logo} alt="Formation-logo" />
            </div>
            <div className="category">
                <span>Catégorie : <b>{cours.category}</b></span>
            </div>
            <div className="difficulte">
                <span className='diff-label'>Difficulté : </span>
                <CareScale className='stars' scaleValue={cours.difficulte} />
            </div>
            <div className="price">
                <span>Price : <b>{cours.price}</b> euros.</span>
            </div>
        </div>
    );
};

export default FormationCard;