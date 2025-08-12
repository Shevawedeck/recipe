create or alter procedure dbo.MeasurementTypeGet(
    @MeasurementTypeId int = 0, 
    @All bit = 0, 
    @MeasurementTypeName varchar(15) = '',
    @IncludeBlank bit = 0)
as
begin
    select m.MeasurementTypeId, m.MeasurementTypeName
    from MeasurementType m
    where m.MeasurementTypeId = @MeasurementTypeId
    or @All = 1
    or (@MeasurementTypeName <> '' and m.MeasurementTypeName like '%' + @MeasurementTypeName + '%')
    union select 0, ''
    where @IncludeBlank = 1
end
go