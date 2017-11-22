RESTORE DATABASE AdventureWorks2014  
FROM DISK = 'C:\Users\Rahevin\Documents\CurrentClasses\CS 460\rahevinslade.github.io\HW6\AdventureWorks2014.bak'  
WITH MOVE 'AdventureWorks2014_Data' TO 'C:\Users\Rahevin\Documents\CurrentClasses\CS 460\rahevinslade.github.io\HW6\AdventureWorks2014_Data.mdf',  
MOVE 'AdventureWorks2014_Log' TO 'C:\Users\Rahevin\Documents\CurrentClasses\CS 460\rahevinslade.github.io\HW6\AdventureWorks2014_Log.ldf' 
