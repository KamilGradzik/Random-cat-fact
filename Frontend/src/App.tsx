import React, { JSX, useState } from 'react';
import catIcon from "./Assets/Images/cat_icon_138789.svg";
import { urlToHttpOptions } from 'url';

const App = ():JSX.Element => {

  const url:string | undefined = process.env.REACT_APP_API_URL;
  const [catFact, setCatFact] = useState<string>("Click below to get random fact about cats!")

  const getCatFact = async () => {
      if(url){
        await fetch(url, {method:"GET"})
          .then(response => response.json())
          .then(data => {
            setCatFact(data.fact);
          
      }) 
    }
  }

  const handleBtnClick = () => {
    getCatFact();
  }

  return (
    <div className="App">
      <div className='cat-fact-wrapper'>
        <div className='cat-fact-container'>
          <div className='cat-fact'>
            <div className='cat-fact-header'>
              <div className='cat-head-icon'></div>
            </div>
            <p className='cat-fact-text'>{catFact}</p>
          </div>
          <button onClick={() => {handleBtnClick()}}>Random fact</button>
        </div>
      </div>
    </div>
  );
}

export default App;
