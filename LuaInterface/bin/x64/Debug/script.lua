package.path = "..."
require "luanet"

luanet.load_assembly("System")
Int32 = luanet.import_type("System.Int32")
