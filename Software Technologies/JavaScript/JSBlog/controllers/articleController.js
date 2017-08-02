const Article = require('mongoose').model('article');

module.exports = {
    createGet: (req, res) =>{
        res.render('article/create')
    },
    createPost: (req, res) =>{
        let articleArgs = req.body;
        let errorMsg = "";

        if(!req.isAuthenticated()){
            errorMsg="Please Log in";
        }else if(!articleArgs.title){
            errorMsg = "Please put in a title";
        }else if(!articleArgs.content){
            errorMsg = "Please write your content";
        }

        if(errorMsg){
            res.render('article/create', {error: errorMsg});
            return;
        }

        articleArgs.author = req.user.id;

        Article.create(articleArgs).then(article =>{
            req.user.articles.push(article);
        });
        req.user.save(error =>{
            if(error){
                res.redirect('/', {error: errorMsg})
            }else{
                res.redirect('/')
            }
        })
    },

    details:(req, res) =>{
        //params пази нещата от URL-a
        let id = req.params.id;

        Article.findById(id).populate('author').then(article => {
            res.render('article/details',article);
        });
    }

};