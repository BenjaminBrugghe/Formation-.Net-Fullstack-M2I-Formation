import './App.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import About from './views/AboutView/About';
import Home from './views/HomeView/Home';
// function App() {
//   return (
//     <div className="App">
//       <Home />
//       <About/>
//     </div>
//   );
// };

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/about' element={<About />} />
          <Route path='/*' element={<Home />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
};
export default App;