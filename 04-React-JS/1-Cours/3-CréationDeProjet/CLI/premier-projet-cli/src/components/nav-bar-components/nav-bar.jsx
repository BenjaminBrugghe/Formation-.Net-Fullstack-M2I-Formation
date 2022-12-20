import React from 'react';
import { NavLink } from 'react-router-dom';
import './nav-bar.css';

const NavBar = () => {
    return (
        <div className='navigation'>
            <ul>
                <NavLink to='/' className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                    <li>Accueil</li>
                </NavLink>
                <NavLink to='/about' className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                    <li>About</li>
                </NavLink>
                <NavLink to='/autre' className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                    <li>Autre</li>
                </NavLink>
            </ul>
            <hr />
        </div>
    );
};
export default NavBar;