import React from 'react';
import './index.css';

export default function Inicio() {
    return(
       <div>
           <header>
           <ul>
            <li><a class="active" href="#home">Inicio</a></li>
            <li><a href="#news">Consultar</a></li>
            <li><a href="#contact">Cadastrar</a></li>
            <li><a href="#about">Cardapio</a></li>
           </ul>
           </header>

           <div className="container">
                <div className="titulo1"><h1>FastFood</h1></div>
                <div className="botoes">
                    <button class="button button3">Cadastre-se</button>
                    <button class="button button3">Login</button>
                    <button class="button button3">Nosso Cardapio</button>
                    <button class="button button3">Consulte</button>
                </div>
           </div>

           <footer></footer>
       </div> 
    )
}