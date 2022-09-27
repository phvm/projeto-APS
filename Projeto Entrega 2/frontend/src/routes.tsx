import { BrowserRouter, Routes, Route } from "react-router-dom";
import LoginScreen from "./pages/LoginScreen";
import RegisterScreen from "./pages/RegisterScreen";
import Home from "./pages/Home";
import VaccinesScreen from './pages/VaccinesScreen'
import { Links } from "./types/enums";

function AppRoutes() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path={Links.Login} element={<LoginScreen />} />
        <Route path={Links.Cadastro} element={<RegisterScreen />} />
        <Route path={Links.Home} element={<Home />} />
        <Route path={Links.Vacinas} element={<VaccinesScreen />} />
      </Routes>
    </BrowserRouter>
  );
}

export default AppRoutes;
