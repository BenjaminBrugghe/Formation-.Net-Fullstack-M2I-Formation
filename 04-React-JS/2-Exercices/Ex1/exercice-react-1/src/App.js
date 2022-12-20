import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Routes, Route, Link, Outlet } from 'react-router-dom';
// import Home from './Views/HomeViews/Home';
// import List from './Views/ListViews/List';
// import AddPersonne from './Views/AddPersonneViews/AddPersonne';
import Header from './Components/HeaderComponent/Header';
import NavBar from './Components/NavBarComponents/NavBar';
import coursList from '../src/data/CoursList';

import { React, useState, useEffect } from 'react';


function App() {

  // Pour sauver les données

  const savedInfos = localStorage.getItem('AddPersonne');
  const [AddPersonne, updateInfos] = useState(savedInfos ? JSON.parse(savedInfos) : []);

  useEffect(() => {
    localStorage.setItem('AddPersonne', JSON.stringify(AddPersonne))
  }, [AddPersonne])
  // Voir F12 => Application => Local Storage => Localhost:3000





  return (
    <div className="App">
      <Header />
      <NavBar AddPersonne={AddPersonne} updateInfos={updateInfos} />
    </div>
  );
};

export default App;
