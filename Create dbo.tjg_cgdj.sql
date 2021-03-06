﻿delete from tjg_cgdj;
insert into tjg_cgdj(autoid,id,cinvcode,iunitcost,iquantity,iprice) select a.autoid,a.id,a.cinvcode,a.iUnitCost,a.iQuantity,a.iprice from rdrecords01 a where a.cInvCode in (select cInvCode from Inventory where cinvccode like '03') and  a.id>=(select min(id) from rdrecord01 where dDate>='1998-01-01 00:00:00' and dDate<='2020-07-17 12:31:16')  and (a.iUnitCost>(select top 1 iUnitCost from rdrecords01 where AutoID < a.AutoID and cinvcode= a.cinvcode order by id desc));
update tjg_cgdj set lautoid = (select top 1 autoid from rdrecords01 where AutoID < tjg_cgdj.autoid and cinvcode=tjg_cgdj.cinvcode order by id desc);
update tjg_cgdj  set lid=b.ID,liunitcost=b.iUnitCost from rdrecords01 b where lautoid=b.autoid;
update tjg_cgdj set whcode=cwhcode,cgrq=dDate from RdRecord01 where RdRecord01.id=tjg_cgdj.id;

select cwhcode,cwhname from warehouse;

ALTER TABLE tjg_cgdj
ALTER COLUMN whname NVARCHAR (100) NULL,