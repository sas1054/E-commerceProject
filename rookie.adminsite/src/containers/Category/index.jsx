import React, { useContext, useState } from 'react';
import { Table, Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import { PenFill, TrashFill, PlusCircleFill } from 'react-bootstrap-icons';
import { Link } from 'react-router-dom';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import { CategoryContext } from '../../Context/categoryContext';

const Category = () => {
  const { categoryItems, deleteCategory } = useContext(CategoryContext);

  const [id, setCategoryId] = useState("");

  const [modal, setModal] = useState(false);

  const handleClose = () => {
    setModal(false);
    setCategoryId("");
  }

  const handleShow = (props) => {
    setModal(true);
    setCategoryId(props);
  }

  const deleteCate = (props) => {
    deleteCategory(props)
    setModal(false);
    setCategoryId("");
    toast.success("Delete success !");
  }

  return (
    <>
      <h2 className="text-center p-3">Category</h2>
      <Button color="success" className="mb-2 ml-2"><PlusCircleFill color="white" size={20} className="mr-2" />
        <Link to={{
          pathname: '/formcategory',
          id: '',
          category: {
            categoryName: '',
            description: '',        
          }
        }} className="text-decoration-none text-white">Create new category</Link>
      </Button>
      <Table striped className="text-center">
        <thead>
          <tr>
            
            <th>Name</th>
            <th>Description</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {
            categoryItems && categoryItems.map(category =>
              <tr key={category.id}>
                
                <td>{category.categoryName}</td>
                <td>{category.description}</td>
                <td>
                  <Button color="secondary" className="mr-2">
                    <Link to={{
                      pathname: '/formcategory',
                      id: category.id,
                      category: {
                        categoryName: category.categoryName,
                        description: category.description,
                        
                      }
                    }}>
                      <PenFill color="white" size={20} />
                    </Link>
                  </Button>
                  <Button color="danger" className="mr-2" onClick={() => handleShow(category.id)}>
                    <TrashFill color="white" size={20} />
                  </Button>
                </td>
              </tr>
            )}
        </tbody>
      </Table>

      <Modal isOpen={modal}>
        <ModalHeader>Delete category</ModalHeader>
        <ModalBody>
          Are you sure delete this category ?
           </ModalBody>
        <ModalFooter>
          <Button color="secondary" onClick={handleClose}>Close</Button>{' '}
          <Button color="danger" onClick={() => deleteCate(id)}>Delete</Button>
        </ModalFooter>
      </Modal>

      <ToastContainer />
    </>
  );
}

export default Category;