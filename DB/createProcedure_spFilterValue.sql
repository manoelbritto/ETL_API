/****** Object:  StoredProcedure [dbo].[spFilterValue]    Script Date: 2019-08-06 10:57:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spFilterValue]
@type varchar(10)
AS
Begin
	if @type is not null
	select *
	from Homicide
	where Homicide_Type = @type

End
GO


