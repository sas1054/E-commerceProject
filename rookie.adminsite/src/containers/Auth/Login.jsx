import React from "react";
import { Button } from "reactstrap";
import { signinRedirect } from "../../services/authService";

export default function Login() {
    const handleClick = () => {
        signinRedirect();
    };
    return (
        <>
            <div className="text-center">
                <p>Please click the button to login !</p>
                <Button color="primary" onClick={handleClick}>
                    Login
                </Button>
            </div>
        </>
    );
}