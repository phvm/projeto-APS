import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginScreen from './pages/LoginScreen'
import { Links } from './types/enums'

function AppRoutes(){
    return(
        <BrowserRouter>
            <Routes>
                <Route path={Links.Login} element={<LoginScreen />} />
            </Routes>
        </BrowserRouter>
    )
}

export default AppRoutes;