const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',
    
    brand: '/api/brands',
    brandId: (id) => `api/brands/${id}`,

};

export default Endpoints;
