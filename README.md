-- 264,6836ms using Contains
-- 1021,514ms using StartWith
-- 39,5446ms using Equals
-- 43,5371ms using == 

If it is a table with more records, the best choice seems to be "Equals", in tables with fewer or single string check, "StartWith" will be a good choice.
