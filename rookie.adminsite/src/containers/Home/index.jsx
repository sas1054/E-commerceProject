import React from 'react';
import { Jumbotron, Button } from 'reactstrap';
import { signinRedirect } from "../../services/authService";

const handleClick = () => {
  signinRedirect();
};
const Home = () => {
  return (
    <div className="text">
      <Jumbotron>
        <h1 className="display-3">Welcome to admin page!</h1>
        <p className="lead pt-1">Please log in to continue</p>
        <hr className="my-2" />
        
        <p className="lead">
        
        <Button color="primary" onClick={handleClick}>Login</Button>
          
        
        </p>
      </Jumbotron>
    </div>
  );
};

export default Home;