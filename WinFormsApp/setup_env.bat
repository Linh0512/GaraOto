@echo off
:: Đổi tên database_name thành tên database của bạn
:: Đổi localhost thành tên server của bạn, thường mặc định là localhost

powershell -Command "[Environment]::SetEnvironmentVariable('DB_SERVER', 'localhost', 'User')"
powershell -Command "[Environment]::SetEnvironmentVariable('DB_NAME', 'database_name', 'User')" 

powershell -Command "[Environment]::GetEnvironmentVariable('DB_SERVER', 'User')"
powershell -Command "[Environment]::GetEnvironmentVariable('DB_NAME', 'User')"
