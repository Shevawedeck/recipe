create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineType varchar(15) = ' ')
as
begin
    select c.CuisineId, c.CuisineType
    from Cuisine c
    where c.CuisineId = @CuisineId
    or @All = 1
    or (@CuisineType <> ' ' and c.CuisineType like '%' + @CuisineType + '%')
end
go

--exec CuisineGet

--exec CuisineGet @All = 1

--exec CuisineGet @CuisineType = 'fr'

--declare @id int
--select top 1 @id = c.CuisineId
--from Cuisine c
--exec CuisineGet @CuisineId = @id