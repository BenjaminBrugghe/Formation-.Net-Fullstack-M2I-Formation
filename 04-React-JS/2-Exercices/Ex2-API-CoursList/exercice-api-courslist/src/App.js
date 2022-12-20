import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import NavBar from './components/NavBarComponent/NavBar';
import Header from './components/HeaderComponent/Header';
import Footer from './components/FooterComponent/Footer';
import { React, useState } from 'react';
import { useEffect } from 'react';

function App() {

  // const [cart,updateCart] = useState([]);  // Pour Cart.jsx

  // Pour conserver le panier
  const savedCart = localStorage.getItem('cart');
  const [cart, updateCart] = useState(savedCart ? JSON.parse(savedCart) : []);

  useEffect(() => {
    localStorage.setItem('cart', JSON.stringify(cart))
  }, [cart])
  // Voir F12 => Application => Local Storage => Localhost:3000

  return (
    <div className="App">
      <Header />
      <NavBar cart={cart} updateCart={updateCart} />
      <Footer />
    </div>
  );
}

export default App;
