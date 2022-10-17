import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Login from './pages/login'
import 'bootstrap/dist/css/bootstrap.min.css';
import logo from "./images/logo.jpeg";
import style from "./main.module.css";
import Inicio from "./pages/inicio";
function App() {
  
  return (
    <Router>
      <div className={style.main}>
        <img src={logo} alt="Logo" className={style.logo} />
        <h2>Sistema bibliotecario UTSV</h2>
      </div>
      <Routes>
        <Route  path="/" element={<Login />} />
        <Route  path='/inicio' element={<Inicio />} />
        <Route path="/inicio/consulta" element={<h2>hygywdw7</h2>} />
        <Route path="/inicio/reservar" element={<h2>hygywdw7</h2>} />
        <Route path="/inicio/catalogo" element={<h2>hygywdw7</h2>} />
        <Route path="/inicio/cerrar%20sesion" element={<h2>hygywdw7</h2>} />
    
      </Routes>
    </Router>
  )
}

export default App
