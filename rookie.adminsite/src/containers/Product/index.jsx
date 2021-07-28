import React, { useContext, useState } from 'react';
import { Table, Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import { StarFill, PenFill, TrashFill, PlusCircleFill } from 'react-bootstrap-icons';
import { Link } from 'react-router-dom';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import { ProductContext } from '../../Context/productContext';

const Product = () => {
  const { productItems, deleteProduct } = useContext(ProductContext);

  const [id, setProductId] = useState("");

  const [modal, setModal] = useState(false);

  const handleClose = () => {
    setModal(false);
    setProductId("");
  }

  const handleShow = (props) => {
    setModal(true);
    setProductId(props);
  }

  const deletePro = (props) => {
    deleteProduct(props)
    setModal(false);
    setProductId("");
    toast.success("Delete success !");
  }

  return (
    <>
      <h2 className="text-center p-3">Product</h2>
      <Button color="success" className="mb-2 ml-2"><PlusCircleFill color="white" size={20} className="mr-2" />
        <Link to={{
          pathname: '/formproduct',
          id: '',
          product: {
            ProductName: '',
            description: '',
            price: 0,
            categoryName: '',
          }
        }} className="text-decoration-none text-white">Create new product</Link>
      </Button>
      <Table striped className="text-center">
        <thead>
          <tr>
            
            <th>Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Category</th>
            <th>Rating</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {
            productItems && productItems.map(product =>
              <tr key={product.id}>
                
                <td>{product.ProductName}</td>
                <td>{product.description}</td>
                <td>{product.price} VND</td>
                <td>{product.categoryName}</td>
                <td>
                  {Array.from(Array(product.rating), () => {
                    return <StarFill color="#ffdd59" size={20} />
                  })}
                </td>
                <td>
                  <Button color="secondary" className="mr-2">
                    <Link to={{
                      pathname: '/formproduct',
                      id: product.id,
                      product: {
                        name: product.ProductName,
                        description: product.description,
                        price: product.price,
                        CategoryId: product.CategoryId,
                        
                      }
                    }}>
                      <PenFill color="white" size={20} />
                    </Link>
                  </Button>
                  <Button color="danger" className="mr-2" onClick={() => handleShow(product.id)}>
                    <TrashFill color="white" size={20} />
                  </Button>
                </td>
              </tr>
            )}
        </tbody>
      </Table>

      <Modal isOpen={modal}>
        <ModalHeader>Delete product</ModalHeader>
        <ModalBody>
          Are you sure delete this product ?
           </ModalBody>
        <ModalFooter>
          <Button color="secondary" onClick={handleClose}>Close</Button>{' '}
          <Button color="danger" onClick={() => deletePro(id)}>Delete</Button>
        </ModalFooter>
      </Modal>

      <ToastContainer />
    </>
  );
}

export default Product;