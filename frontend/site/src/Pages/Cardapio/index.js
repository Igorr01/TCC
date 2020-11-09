import React from 'react'
import './index.css'

export default function Cardapio() {
    return(
        <div>
         <header>   
           <ul>
            <li><a href="#home">Inicio</a></li>
            <li><a href="#news">Consultar</a></li>
            <li><a href="#contact">Cadastrar</a></li>
            <li><a class="active" href="#about">Cardapio</a></li>
           </ul>
         </header>


           <div className="container">
                <h1 className="titulocardapio">Acesse nosso Cardapio</h1>
                <button class="button button3">Clique aqui</button>
           </div>


           <footer></footer>


        </div>
    )
}