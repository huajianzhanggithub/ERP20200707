USE [UFDATA_999_2016]
GO

/****** 对象: View [dbo].[tjg_cgjg] 脚本日期: 2020-7-18 16:58:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER VIEW [dbo].[tjg_cgjg] AS
select ISNULL(NEWID(), 'd1e57ca7-6eee-495a-be13-73d5e7d51f36') AS Id, c.ccode,a.whcode,a.cgrq,e.cWhName,b.cInvName,b.cInvStd,a.iquantity,a.iprice,a.iunitcost,d.ccode as lccode,a.liunitcost from tjg_cgdj a,Inventory b,rdrecord01 c,rdrecord01 d,Warehouse e where a.id=c.id and a.cinvcode=b.cInvCode and a.lid=d.id and a.whcode=e.cWhCode;

alter view [dbo].[tjg_cgjg]
  add constraint ID_PK primary key (Id)
  disable novalidate;