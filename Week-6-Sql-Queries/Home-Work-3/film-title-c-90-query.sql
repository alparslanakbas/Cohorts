select * from film 
where title like 'C%'
	and length >90
	and rental_rate = 2.99
order by title asc