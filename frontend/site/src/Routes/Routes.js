import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom'

import Inicio from '../Pages/Inicio'
import Cardapio from '../Pages/Cardapio'

export default function Routes() {
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={Inicio} />
                <Route path="/Cardapio" component={Cardapio} />
            </Switch>
        </BrowserRouter>
    )
}