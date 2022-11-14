import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Login from "./pages/login";
import "bootstrap/dist/css/bootstrap.min.css";
import logo from "./images/logo.jpeg";
import style from "./main.module.css";
import Inicio from "./pages/inicio";
import Consulta from "./pages/consulta";
import Reservar from "./pages/reservar";
import Catalogo from "./pages/catalogo";
import { Link } from "react-router-dom";
import { useState } from "react";
import Books from "./pages/catalogo/books";
import Reservas from "./pages/reservar/reservas";

function App() {
  const [loged, setIsLoggedIn] = useState(false);
  return (
    <Router>
      <div className={style.main}>
        <Link to="/inicio">
          <img src={logo} alt="Logo" className={style.logo} />
        </Link>
        <h2>Sistema bibliotecario UTSV</h2>
      </div>
      <Routes>
        <Route path="/" element={<Login setIsLoggedIn={setIsLoggedIn} />} />
        <Route
          path="/inicio"
          element={<Inicio loged={loged} setIsLoggedIn={setIsLoggedIn}  /> } />
        <Route path="/inicio/consulta" element={<Consulta loged={loged} />} />
        <Route path="/inicio/reservar" element={<Reservar loged={loged} />} />
        <Route
          path="/inicio/reservar/all"
          element={<Reservas loged={loged} />}
        />
        <Route path="/inicio/catalago" element={<Catalogo loged={loged} />} />
        <Route
          path="/inicio/catalago/:type"
          element={<Books loged={loged} />}
        />
      </Routes>
    </Router>
  );
}

export default App;
