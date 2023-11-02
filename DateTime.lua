local v=os.time() --取到的是格林威治偏移时间(不含时区)

--23v=1698939040 --23:30
print(v)

local s = os.date('%Y-%m-%d %H:%M',v) --自动加入时区 (会随本机时区变动)
print(""..s)

s = os.date('!%Y-%m-%d %H:%M',v) --强制不加时区(不会随时区变动) 
print("!"..s)