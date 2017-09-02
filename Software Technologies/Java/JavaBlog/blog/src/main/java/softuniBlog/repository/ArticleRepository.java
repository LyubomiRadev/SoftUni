package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import softuniBlog.entity.Article;

//казваме кое е entity-то което ще управляваме и какъв тип е ID-то
@Repository
public interface ArticleRepository extends JpaRepository<Article,Integer>{

}
