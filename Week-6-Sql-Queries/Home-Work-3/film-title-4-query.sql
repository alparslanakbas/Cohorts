select title from film 
where (length(title) - length(replace(lower(title), 't', ''))) >=4
order by title asc