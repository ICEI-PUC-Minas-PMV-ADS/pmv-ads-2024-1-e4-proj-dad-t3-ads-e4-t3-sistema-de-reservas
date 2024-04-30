'use client'
import {useState} from 'react';

const Navbar = ({ user }) => {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const toggleMenu = () => {
    setIsMenuOpen(!isMenuOpen);
  };

  return (
    <div className="flex flex-wrap items-center justify-between p-3 bg-cyan-400">
      <h2 className="text-xl font-bold ml-4">RESERVAS</h2>
      <div className="flex md:hidden">
        <button onClick={toggleMenu}>
          <img src={isMenuOpen ? "https://img.icons8.com/fluent-systems-regular/2x/close-window.png" : "https://img.icons8.com/fluent-systems-regular/2x/menu-squared-2.png"} className="block" width="40" height="40" />
        </button>
      </div>
      <div className={`w-full md:w-auto md:flex text-right text-bold mt-5 md:mt-0 border-t-2 border-blue-900 ${isMenuOpen ? 'block' : 'hidden'}`}>
        {user ? (
          user.userType === 'Condominos' ? (
            <>
              <a href="/privado/reservas" className="block md:inline-block text-white font-bold hover:text-blue-500 px-3 py-3 border-b-2 hover:shadow-md hover:bg-cyan-500 border-cyan-600 md:border-none">Reservas</a>
              <a href="/privado/condominios" className="block md:inline-block text-white font-bold hover:text-blue-500 px-3 py-3 border-b-2 hover:shadow-md hover:bg-cyan-500 border-cyan-600 md:border-none">Condomínios</a>
            </>
          ) : (
            <>
              <a href="/privado/reservas" className="block md:inline-block text-white font-bold hover:text-blue-500 px-3 py-3 border-b-2 hover:shadow-md hover:bg-cyan-500 border-cyan-600 md:border-none">Reservas</a>
              <a href="/privado/locais" className="block md:inline-block text-white font-bold hover:text-blue-500 px-3 py-3 border-b-2 hover:shadow-md hover:bg-cyan-500 border-cyan-600 md:border-none">Locais</a>
              <a href="/privado/condominos" className="block md:inline-block text-white font-bold hover:text-blue-500 px-3 py-3 border-b-2 hover:shadow-md hover:bg-cyan-500 border-cyan-600 md:border-none">Condôminos</a>
            </>
            
          )
          
        ) : (
          <></>
        )}
        {/* <a href="#" className="block md:inline-block text-blue-900 hover:text-blue-500 px-3 py-3 border-b-2 border-blue-900 md:border-none">Contact</a> */}
      </div>
      {user ? (
          <a href="#" className="hidden md:flex w-full md:w-auto px-4 py-2 text-right bg-blue-900 hover:bg-blue-500 text-white md:rounded">Sair</a>
      ) : (
        <a href="#" className="hidden md:flex w-full md:w-auto px-4 py-2 text-right bg-blue-900 hover:bg-blue-500 text-white md:rounded">Entrar</a>
      )}
      
    </div>
  );
};

export default Navbar;

