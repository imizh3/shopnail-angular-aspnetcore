/****** Object:  StoredProcedure [dbo].[WEB_GETNGANHNHOM]    Script Date: 08/10/2020 15:49:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WEB_GETNGANHNHOM]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[WEB_GETNGANHNHOM]
GO
create proc [dbo].[WEB_GETNGANHNHOM]
(
	@Madonvi varchar(20)
)
as
select * from (
select Manganh as Ma, Madonvi, Tennganh as Ten, null as Macha  from Nganhhang
union 
select Manhomhang as Ma, Madonvi, Tennhomhang as Ten, Manganh as Macha from Nhomhang
) n
where Madonvi=@Madonvi
order by Ten
GO


