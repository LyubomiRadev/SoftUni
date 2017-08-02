const mongoose = require('mongoose');

/**създаване на entity в базата данни*/

let articleSchema = mongoose.Schema({
    title: {type: String, required: true},
    author: {type: mongoose.Schema.Types.ObjectId, required: true, ref:'User'},
    content: {type: text, required: true},
    date: {type: Date, default: Date.now()}
});

const Article = mongoose.model('article', articleSchema);

module.exports = Article;

/**let articleSchema = mongoose.Schema({
    title: {type: String, required: true},
    author: {type: mongoose.Schema.Types.ObjectId, required: true, ref: 'User'},
    content: {type: String, required: true},
    date: {type: Date, default: Date.now()}
});

const Article = mongoose.model('article', articleSchema);

module.exports = Article;*/