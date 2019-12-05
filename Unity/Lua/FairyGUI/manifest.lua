-- Generated by CSharp.lua Compiler
return function (out)
  do
    out = (out and #out > 0) and (out .. '.') or ""
    local require = require
    local load = function(module) return require(out .. module) end

    -- load all files
    load("FUI")
    load("FUIComponent")
    load("FUIStackComponent")
    load("FUIWindowComponent")
    load("GComponentHelper")
    load("GObjectHelper")
  end

  System.init({
    "DCET.Hotfix.FUI",
    "DCET.Hotfix.FUIComponent",
    "DCET.Hotfix.FUIWindowComponent",
    "DCET.Hotfix.FUIAwakeSystem",
    "DCET.Hotfix.FUIComponentAwakeSystem",
    "DCET.Hotfix.FUIStackComponent",
    "DCET.Hotfix.FUIWindowComponentAwakeSystem",
    "DCET.Hotfix.GComponentHelper",
    "DCET.Hotfix.GObjectHelper"
  })
end