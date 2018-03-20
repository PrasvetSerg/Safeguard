USE Safeguard
SELECT *
	FROM dbo.organization
	WHERE organization_name LIKE'%нафтан%'
	ORDER BY organization_id
	
DECLARE @organization_id_correct int =360
DECLARE @organization_id int =1188	
	
SELECT *
	FROM dbo.offense
	WHERE organization_id=@organization_id
	
UPDATE dbo.offense
	SET organization_id= @organization_id_correct
	WHERE organization_id=@organization_id	
	
DELETE FROM dbo.organization WHERE organization_id =@organization_id



	