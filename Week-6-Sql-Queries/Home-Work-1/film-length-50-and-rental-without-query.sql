select * from film 
where length <= 50 
	and rental_rate not in (4.99) 
order by length asc