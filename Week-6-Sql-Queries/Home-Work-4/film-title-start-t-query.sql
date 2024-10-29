select count(*) as count_of_films
from film
where title like 'T%' 
  and rating = 'G';
