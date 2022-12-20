import React from 'react';
import NavBar from '../../components/nav-bar-components/nav-bar';
import './Home.css';

const Home = () => {
    return (
        <div className='ConteneurHome'>
            <NavBar/>
            <h1>This is Home.jsx, from App.js</h1>
            <img src="./img/logo192.png" alt="logo192" />
        </div>
    );
};

export default Home;