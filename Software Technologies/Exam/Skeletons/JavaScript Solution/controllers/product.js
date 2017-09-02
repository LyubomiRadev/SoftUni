const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find({}).then(product =>{
            res.render("product/index", {'products': product})
        })
    	},
	createGet: (req, res) => {

        res.render("product/create");
	},
	createPost: (req, res) => {
        let listArg = req.body;

        Product.create(listArg).then(prd =>{
            res.redirect("/")
        });
	},
	editGet: (req, res) => {
        let productId = req.params.id;

        Product.findById( productId).then(prd =>{
            res.render("product/edit", prd)
        });
	},
	editPost: (req, res) => {
        let productId = req.params.id;
        let productArgs = req.body;

        Product.findByIdAndUpdate(productId,productArgs).then(prd =>{
            res.redirect("/")
        });
	}
};