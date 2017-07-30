

luanet.load_assembly("TestLuaInterface")
Player = luanet.import_type("Player")
Program = luanet.import_type("Program");
luanet.load_assembly("TestLibrary")
Algorithm = luanet.import_type("TestLibrary.Algorithm")

print(Algorithm.Add(1,2))

void,len = Program.GetLength("www.yzl.com");
print(len)

a = 3
b = 5
void,b = Program.Calc(a,b);
print(b)

local player = Player()
player:Render()
player:Move(-1, -1)
player:Render()