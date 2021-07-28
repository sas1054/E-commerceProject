import React, { useContext } from 'react';
import { InputGroup, InputGroupAddon, InputGroupText, Input, Button, Container } from 'reactstrap';
import * as Icon from 'react-bootstrap-icons';
import { Link, useHistory } from 'react-router-dom';
import { useFormik } from 'formik';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import { ProductContext } from '../../Context/productContext';
import { Thumb } from '../../utils/thumb';

const FormProduct = (props) => {
    let history = useHistory();

    const id = props.location.id;
    const initialValues = props.location.product;

    const { categoryItems, postProduct, putProduct } = useContext(ProductContext);

    const formik = useFormik({
        initialValues,
        onSubmit: (values, actions) => {
            actions.setSubmitting(true);
            setTimeout(() => {
                var formData = new FormData();

                Object.keys(values).forEach(key => {
                    formData.append(key, values[key])
                });

                (!id) ? postProduct(formData) : putProduct(id, formData)

                actions.setSubmitting(false);

                history.push('/product')
            }, 1500);

            (!id) ? toast.success("Create new product success !") : toast.success("Edit product success !")
        }
    });

    return (
        <>
            <h2 className="text-center p-3">Form Product</h2>
            <div>
                <form onSubmit={formik.handleSubmit}>
                    <Container>
                        <InputGroup>
                            <InputGroupAddon addonType="prepend">
                                <InputGroupText><Icon.Spellcheck /></InputGroupText>
                            </InputGroupAddon>
                            <Input name='ProductName' value={formik.values.ProductName} onChange={formik.handleChange} placeholder="Name" />
                        </InputGroup>
                        <br />
                        <InputGroup>
                            <InputGroupAddon addonType="prepend">
                                <InputGroupText><Icon.InfoCircle /></InputGroupText>
                            </InputGroupAddon>
                            <Input name='description' value={formik.values.description} onChange={formik.handleChange} placeholder="Description" />
                        </InputGroup>
                        <br />
                        <InputGroup>
                            <InputGroupAddon addonType="prepend">
                                <InputGroupText><Icon.Gem /></InputGroupText>
                            </InputGroupAddon>
                            <Input name='price' type='number' value={formik.values.price} onChange={formik.handleChange} placeholder="Price" />
                        </InputGroup>
                        <br />
                        <InputGroup>
                            <InputGroupAddon addonType="prepend">
                                <InputGroupText><Icon.Collection /></InputGroupText>
                            </InputGroupAddon>
                            <Input type="select" name="CategoryId" value={formik.values.CategoryId} onChange={formik.handleChange}>
                                {
                                    categoryItems && categoryItems.map(category =>
                                        <option selected value={category.CategoryId}>{category.categoryName}</option>
                                    )}
                            </Input>
                        </InputGroup>
                        <br />
                        <div className="text-center m-3">
                            <Button color="secondary" className="mr-2" type="button">
                                <Link to="/product" className="text-decoration-none text-white">Close</Link>
                            </Button>
                            <Button disabled={formik.isSubmitting} type='submit' color="success">Submit</Button>
                        </div>
                    </Container>
                </form>
            </div>

            <ToastContainer hideProgressBar />
        </>
    );
}

export default FormProduct;