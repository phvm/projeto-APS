import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginScreen from './pages/LoginScreen'
import RegisterScreen from "./pages/RegisterScreen";
import { Links } from './types/enums'

function AppRoutes(){
    return(
        <BrowserRouter>
            <Routes>
                <Route path={Links.Login} element={LoginScreen} />
                <Route path={Links.Cadastro} element={<RegisterScreen />} />
            </Routes>
        </BrowserRouter>
    )
}

export default AppRoutes;