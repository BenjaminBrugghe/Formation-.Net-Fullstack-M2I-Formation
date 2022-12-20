import React from 'react';
import { useState } from 'react';
import './Cart.css';

const Cart = ({ cart, updateCart }) => {
    // Déclaration d'un state isOpen (boolean) pour savoir si le panier est affiché ou non
    const [isOpen, setIsOpen] = useState(false);

    const Total = cart.reduce((acc, cours) => acc + cours.amount * cours.price, 0);

    // Retourne du JSX conditionné par le state isOpen
    return isOpen ? (
        <div className='relative'>
            <div className="cart-list over">
                {
                    // S'il y a des formations dans le panier
                    cart.length > 0 ?
                        <div>
                            <h2>Mon panier</h2>
                            <div className="inner-card">
                                {/* Affichage des formations présentes dans le panier */}
                                <div>
                                    {
                                        cart.map(({ name, price, amount }, index) => (
                                            <div key={`${name} - ${index}`}>
                                                {name} : {price} € x {amount}
                                                <hr></hr>
                                            </div>
                                        ))
                                    }
                                </div>
                                <h3>Total : {Total}€</h3>
                            </div>
                            {/* Pour vider le panier (updateCart([]) renvois un tableau vide) */}
                            <button className='btn btn-secondary space-top' onClick={() => updateCart([])}>Vider le panier</button>
                        </div>

                        // Sinon
                        :
                        <div className='vide'>
                            Votre panier est vide !
                        </div>
                }
                <button className='btn btn-secondary spaced' onClick={() => setIsOpen(false)}>Fermer le panier</button>
            </div>
        </div>
    )
        :
        (
            <button className='btn btn-secondary' onClick={() => setIsOpen(true)}>Ouvrir le panier</button>
        );
};

export default Cart;