-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET.Hotfix", function (namespace)
  namespace.interface("IUpdateSystem", function ()
    return {}
  end)

  namespace.class("UpdateSystem_1", function (namespace)
    return function (T)
      local Run, Type
      Run = function (this, o)
        Update(this, System.cast(T, o))
      end
      Type = function (this)
        return System.typeof(T)
      end
      return {
        __inherits__ = function (out)
          return {
            out.DCET.Hotfix.IUpdateSystem
          }
        end,
        Run = Run,
        Type = Type
      }
    end
  end)
end)
