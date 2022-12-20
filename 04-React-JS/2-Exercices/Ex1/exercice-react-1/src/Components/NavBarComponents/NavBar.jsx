import React from 'react';
import './NavBar.css';
import { BrowserRouter, Routes, Route, Link, Outlet } from 'react-router-dom';
import Home from '../../Views/HomeViews/Home';
import List from '../../Views/ListViews/List';
import AddPersonne from '../../Views/AddPersonneViews/AddPersonne';

const NavBar = () => {
    return (
        <div className='navigation'>
            <BrowserRouter>
                <div id='idNavBar'>
                    <button className='bouton'>
                        <Link to='/'>Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to='/list'>Liste</Link>
                    </button>
                    <button className='bouton'>
                        <Link to='/addPerson'>Add Person</Link>
                    </button>
                </div>
                <Routes>
                    <Route path='/' element={<Home />} />
                    <Route path='/list' element={<List />} />
                    <Route path='/addPerson' element={<AddPersonne />} />
                </Routes>
            </BrowserRouter>
            <div className="container">
                <Outlet />
            </div>
        </div>
    );
};

export default NavBar;