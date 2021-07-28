import React from "react";
import { Button } from "reactstrap";
import { signoutRedirect } from "../../services/authService";

export default function Logout() {
    const handleClick = () => {
        signoutRedirect();
    };
    return (
        <>
            <div className="text-center">
                <p>Please click the button to logout !</p>
                <Button color="primary" onClick={handleClick}>
                    Logout
                </Button>
            </div>
        </>
    );
}