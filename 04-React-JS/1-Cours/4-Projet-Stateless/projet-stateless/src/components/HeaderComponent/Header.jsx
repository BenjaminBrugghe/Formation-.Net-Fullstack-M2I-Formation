import React from 'react';
import './Header.css';

const Header = () => {
    return (
        <div className='banner'>
            <img src="./img/M2ILOGO2.png" alt="M2i Logo" />
            <h3>M2i Formation</h3>
            <span className='description'>Votre formation sur mesure</span>
        </div>
    );
};

export default Header;