const userController = require('./../controllers/user');
const homeController = require('./../controllers/home');
const articleContrroller = require('./../controllers/articleController');

module.exports = (app) => {
    app.get('/', homeController.index);

    app.get('/user/register', userController.registerGet);
    app.post('/user/register', userController.registerPost);

    app.get('/user/login', userController.loginGet);
    app.post('/user/login', userController.loginPost);

    app.get('/user/logout', userController.logout);
    app.get('/user/details/:id', userController.details);

    app.get('/article/create', articleContrroller.createGet);
    app.post('/article/create', articleContrroller.createPost);

    app.get('/article/details/:id', articleContrroller.details);
};

