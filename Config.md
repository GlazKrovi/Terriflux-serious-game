# Dossier de Configuration - Projet Godot

## Objectif
L'objectif de ce dossier est d'assurer l'intégration de l'application Godot dans un environnement informatique spécifique et de la préparer pour son utilisation optimale.
---
## Détails
Afin de garantir le bon fonctionnement de l'application, merci de tenir compte des aspects suivant :

### Configuration Requise :
#### Sur Window
- Window 10 ou supérieur 
- 4G de RAM
- 1G de mémoire HDD ou SSD

#### Sur Linux
- Ubuntu 22 LTS ou supérieur, ou dérivé de ce dernier (Debian, Kubuntu, ...)
- 4G de RAM
- 1G de mémoire HDD ou SSD

### Dossiers et Fichiers :
Aucun dossier ou fichier suplémentaire n'est a créer. Evitez simplement de supprimer les existants.
---
## Création et/ou mise à jour des dossiers et fichiers utilisés par l'application pour son bon fonctionnement.
### Données de Configuration :
Rien de particulier.
---
## Inclusion des fichiers de configuration, des entrées de base, des variables d'environnement, etc.
### Package de l'Application :

Rien de particulier à réaliser de ce côté. Le dépôt git doit déjà contenir toute l'arborescence nécessaire pour éxecuter l'application ou continuer son développement. En voici une déscription détaillée :

#### __Executables__
```txt 
Window_install
|   Terriflux.exe
|
\---data_Terriflux_x86_64
        api-ms-win-core-console-l1-1-0.dll
        api-ms-win-core-console-l1-2-0.dll
        api-ms-win-core-datetime-l1-1-0.dll
        api-ms-win-core-debug-l1-1-0.dll
        api-ms-win-core-errorhandling-l1-1-0.dll
        api-ms-win-core-fibers-l1-1-0.dll
        api-ms-win-core-file-l1-1-0.dll
        api-ms-win-core-file-l1-2-0.dll
        api-ms-win-core-file-l2-1-0.dll
        api-ms-win-core-handle-l1-1-0.dll
        api-ms-win-core-heap-l1-1-0.dll
        api-ms-win-core-interlocked-l1-1-0.dll
        api-ms-win-core-libraryloader-l1-1-0.dll
        api-ms-win-core-localization-l1-2-0.dll
        api-ms-win-core-memory-l1-1-0.dll
        api-ms-win-core-namedpipe-l1-1-0.dll
        api-ms-win-core-processenvironment-l1-1-0.dll
        api-ms-win-core-processthreads-l1-1-0.dll
        api-ms-win-core-processthreads-l1-1-1.dll
        api-ms-win-core-profile-l1-1-0.dll
        api-ms-win-core-rtlsupport-l1-1-0.dll
        api-ms-win-core-string-l1-1-0.dll
        api-ms-win-core-synch-l1-1-0.dll
        api-ms-win-core-synch-l1-2-0.dll
        api-ms-win-core-sysinfo-l1-1-0.dll
        api-ms-win-core-timezone-l1-1-0.dll
        api-ms-win-core-util-l1-1-0.dll
        api-ms-win-crt-conio-l1-1-0.dll
        api-ms-win-crt-convert-l1-1-0.dll
        api-ms-win-crt-environment-l1-1-0.dll
        api-ms-win-crt-filesystem-l1-1-0.dll
        api-ms-win-crt-heap-l1-1-0.dll
        api-ms-win-crt-locale-l1-1-0.dll
        api-ms-win-crt-math-l1-1-0.dll
        api-ms-win-crt-multibyte-l1-1-0.dll
        api-ms-win-crt-private-l1-1-0.dll
        api-ms-win-crt-process-l1-1-0.dll
        api-ms-win-crt-runtime-l1-1-0.dll
        api-ms-win-crt-stdio-l1-1-0.dll
        api-ms-win-crt-string-l1-1-0.dll
        api-ms-win-crt-time-l1-1-0.dll
        api-ms-win-crt-utility-l1-1-0.dll
        clretwrc.dll
        clrjit.dll
        coreclr.dll
        createdump.exe
        dbgshim.dll
        GodotSharp.dll
        hostfxr.dll
        hostpolicy.dll
        Microsoft.CSharp.dll
        Microsoft.DiaSymReader.Native.amd64.dll
        Microsoft.VisualBasic.Core.dll
        Microsoft.VisualBasic.dll
        Microsoft.Win32.Primitives.dll
        Microsoft.Win32.Registry.dll
        mscordaccore.dll
        mscordaccore_amd64_amd64_6.0.2423.51814.dll
        mscordbi.dll
        mscorlib.dll
        mscorrc.dll
        msquic.dll
        netstandard.dll
        System.AppContext.dll
        System.Buffers.dll
        System.Collections.Concurrent.dll
        System.Collections.dll
        System.Collections.Immutable.dll
        System.Collections.NonGeneric.dll
        System.Collections.Specialized.dll
        System.ComponentModel.Annotations.dll
        System.ComponentModel.DataAnnotations.dll
        System.ComponentModel.dll
        System.ComponentModel.EventBasedAsync.dll
        System.ComponentModel.Primitives.dll
        System.ComponentModel.TypeConverter.dll
        System.Configuration.dll
        System.Console.dll
        System.Core.dll
        System.Data.Common.dll
        System.Data.DataSetExtensions.dll
        System.Data.dll
        System.Diagnostics.Contracts.dll
        System.Diagnostics.Debug.dll
        System.Diagnostics.DiagnosticSource.dll
        System.Diagnostics.FileVersionInfo.dll
        System.Diagnostics.Process.dll
        System.Diagnostics.StackTrace.dll
        System.Diagnostics.TextWriterTraceListener.dll
        System.Diagnostics.Tools.dll
        System.Diagnostics.TraceSource.dll
        System.Diagnostics.Tracing.dll
        System.dll
        System.Drawing.dll
        System.Drawing.Primitives.dll
        System.Dynamic.Runtime.dll
        System.Formats.Asn1.dll
        System.Globalization.Calendars.dll
        System.Globalization.dll
        System.Globalization.Extensions.dll
        System.IO.Compression.Brotli.dll
        System.IO.Compression.dll
        System.IO.Compression.FileSystem.dll
        System.IO.Compression.Native.dll
        System.IO.Compression.ZipFile.dll
        System.IO.dll
        System.IO.FileSystem.AccessControl.dll
        System.IO.FileSystem.dll
        System.IO.FileSystem.DriveInfo.dll
        System.IO.FileSystem.Primitives.dll
        System.IO.FileSystem.Watcher.dll
        System.IO.IsolatedStorage.dll
        System.IO.MemoryMappedFiles.dll
        System.IO.Pipes.AccessControl.dll
        System.IO.Pipes.dll
        System.IO.UnmanagedMemoryStream.dll
        System.Linq.dll
        System.Linq.Expressions.dll
        System.Linq.Parallel.dll
        System.Linq.Queryable.dll
        System.Memory.dll
        System.Net.dll
        System.Net.Http.dll
        System.Net.Http.Json.dll
        System.Net.HttpListener.dll
        System.Net.Mail.dll
        System.Net.NameResolution.dll
        System.Net.NetworkInformation.dll
        System.Net.Ping.dll
        System.Net.Primitives.dll
        System.Net.Quic.dll
        System.Net.Requests.dll
        System.Net.Security.dll
        System.Net.ServicePoint.dll
        System.Net.Sockets.dll
        System.Net.WebClient.dll
        System.Net.WebHeaderCollection.dll
        System.Net.WebProxy.dll
        System.Net.WebSockets.Client.dll
        System.Net.WebSockets.dll
        System.Numerics.dll
        System.Numerics.Vectors.dll
        System.ObjectModel.dll
        System.Private.CoreLib.dll
        System.Private.DataContractSerialization.dll
        System.Private.Uri.dll
        System.Private.Xml.dll
        System.Private.Xml.Linq.dll
        System.Reflection.DispatchProxy.dll
        System.Reflection.dll
        System.Reflection.Emit.dll
        System.Reflection.Emit.ILGeneration.dll
        System.Reflection.Emit.Lightweight.dll
        System.Reflection.Extensions.dll
        System.Reflection.Metadata.dll
        System.Reflection.Primitives.dll
        System.Reflection.TypeExtensions.dll
        System.Resources.Reader.dll
        System.Resources.ResourceManager.dll
        System.Resources.Writer.dll
        System.Runtime.CompilerServices.Unsafe.dll
        System.Runtime.CompilerServices.VisualC.dll
        System.Runtime.dll
        System.Runtime.Extensions.dll
        System.Runtime.Handles.dll
        System.Runtime.InteropServices.dll
        System.Runtime.InteropServices.RuntimeInformation.dll
        System.Runtime.Intrinsics.dll
        System.Runtime.Loader.dll
        System.Runtime.Numerics.dll
        System.Runtime.Serialization.dll
        System.Runtime.Serialization.Formatters.dll
        System.Runtime.Serialization.Json.dll
        System.Runtime.Serialization.Primitives.dll
        System.Runtime.Serialization.Xml.dll
        System.Security.AccessControl.dll
        System.Security.Claims.dll
        System.Security.Cryptography.Algorithms.dll
        System.Security.Cryptography.Cng.dll
        System.Security.Cryptography.Csp.dll
        System.Security.Cryptography.Encoding.dll
        System.Security.Cryptography.OpenSsl.dll
        System.Security.Cryptography.Primitives.dll
        System.Security.Cryptography.X509Certificates.dll
        System.Security.dll
        System.Security.Principal.dll
        System.Security.Principal.Windows.dll
        System.Security.SecureString.dll
        System.ServiceModel.Web.dll
        System.ServiceProcess.dll
        System.Text.Encoding.CodePages.dll
        System.Text.Encoding.dll
        System.Text.Encoding.Extensions.dll
        System.Text.Encodings.Web.dll
        System.Text.Json.dll
        System.Text.RegularExpressions.dll
        System.Threading.Channels.dll
        System.Threading.dll
        System.Threading.Overlapped.dll
        System.Threading.Tasks.Dataflow.dll
        System.Threading.Tasks.dll
        System.Threading.Tasks.Extensions.dll
        System.Threading.Tasks.Parallel.dll
        System.Threading.Thread.dll
        System.Threading.ThreadPool.dll
        System.Threading.Timer.dll
        System.Transactions.dll
        System.Transactions.Local.dll
        System.ValueTuple.dll
        System.Web.dll
        System.Web.HttpUtility.dll
        System.Windows.dll
        System.Xml.dll
        System.Xml.Linq.dll
        System.Xml.ReaderWriter.dll
        System.Xml.Serialization.dll
        System.Xml.XDocument.dll
        System.Xml.XmlDocument.dll
        System.Xml.XmlSerializer.dll
        System.Xml.XPath.dll
        System.Xml.XPath.XDocument.dll
        Terriflux.deps.json
        Terriflux.dll
        Terriflux.pdb
        Terriflux.runtimeconfig.json
        ucrtbase.dll
        WindowsBase.dll
```

```txt 
Linux_install
|   Terriflux.x86_64
|
\---data_Terriflux_x86_64
        createdump
        GodotSharp.dll
        libclrjit.so
        libcoreclr.so
        libcoreclrtraceptprovider.so
        libdbgshim.so
        libhostfxr.so
        libhostpolicy.so
        libmscordaccore.so
        libmscordbi.so
        libSystem.Globalization.Native.so
        libSystem.IO.Compression.Native.so
        libSystem.Native.so
        libSystem.Net.Security.Native.so
        libSystem.Security.Cryptography.Native.OpenSsl.so
        Microsoft.CSharp.dll
        Microsoft.VisualBasic.Core.dll
        Microsoft.VisualBasic.dll
        Microsoft.Win32.Primitives.dll
        Microsoft.Win32.Registry.dll
        mscorlib.dll
        netstandard.dll
        System.AppContext.dll
        System.Buffers.dll
        System.Collections.Concurrent.dll
        System.Collections.dll
        System.Collections.Immutable.dll
        System.Collections.NonGeneric.dll
        System.Collections.Specialized.dll
        System.ComponentModel.Annotations.dll
        System.ComponentModel.DataAnnotations.dll
        System.ComponentModel.dll
        System.ComponentModel.EventBasedAsync.dll
        System.ComponentModel.Primitives.dll
        System.ComponentModel.TypeConverter.dll
        System.Configuration.dll
        System.Console.dll
        System.Core.dll
        System.Data.Common.dll
        System.Data.DataSetExtensions.dll
        System.Data.dll
        System.Diagnostics.Contracts.dll
        System.Diagnostics.Debug.dll
        System.Diagnostics.DiagnosticSource.dll
        System.Diagnostics.FileVersionInfo.dll
        System.Diagnostics.Process.dll
        System.Diagnostics.StackTrace.dll
        System.Diagnostics.TextWriterTraceListener.dll
        System.Diagnostics.Tools.dll
        System.Diagnostics.TraceSource.dll
        System.Diagnostics.Tracing.dll
        System.dll
        System.Drawing.dll
        System.Drawing.Primitives.dll
        System.Dynamic.Runtime.dll
        System.Formats.Asn1.dll
        System.Globalization.Calendars.dll
        System.Globalization.dll
        System.Globalization.Extensions.dll
        System.IO.Compression.Brotli.dll
        System.IO.Compression.dll
        System.IO.Compression.FileSystem.dll
        System.IO.Compression.ZipFile.dll
        System.IO.dll
        System.IO.FileSystem.AccessControl.dll
        System.IO.FileSystem.dll
        System.IO.FileSystem.DriveInfo.dll
        System.IO.FileSystem.Primitives.dll
        System.IO.FileSystem.Watcher.dll
        System.IO.IsolatedStorage.dll
        System.IO.MemoryMappedFiles.dll
        System.IO.Pipes.AccessControl.dll
        System.IO.Pipes.dll
        System.IO.UnmanagedMemoryStream.dll
        System.Linq.dll
        System.Linq.Expressions.dll
        System.Linq.Parallel.dll
        System.Linq.Queryable.dll
        System.Memory.dll
        System.Net.dll
        System.Net.Http.dll
        System.Net.Http.Json.dll
        System.Net.HttpListener.dll
        System.Net.Mail.dll
        System.Net.NameResolution.dll
        System.Net.NetworkInformation.dll
        System.Net.Ping.dll
        System.Net.Primitives.dll
        System.Net.Quic.dll
        System.Net.Requests.dll
        System.Net.Security.dll
        System.Net.ServicePoint.dll
        System.Net.Sockets.dll
        System.Net.WebClient.dll
        System.Net.WebHeaderCollection.dll
        System.Net.WebProxy.dll
        System.Net.WebSockets.Client.dll
        System.Net.WebSockets.dll
        System.Numerics.dll
        System.Numerics.Vectors.dll
        System.ObjectModel.dll
        System.Private.CoreLib.dll
        System.Private.DataContractSerialization.dll
        System.Private.Uri.dll
        System.Private.Xml.dll
        System.Private.Xml.Linq.dll
        System.Reflection.DispatchProxy.dll
        System.Reflection.dll
        System.Reflection.Emit.dll
        System.Reflection.Emit.ILGeneration.dll
        System.Reflection.Emit.Lightweight.dll
        System.Reflection.Extensions.dll
        System.Reflection.Metadata.dll
        System.Reflection.Primitives.dll
        System.Reflection.TypeExtensions.dll
        System.Resources.Reader.dll
        System.Resources.ResourceManager.dll
        System.Resources.Writer.dll
        System.Runtime.CompilerServices.Unsafe.dll
        System.Runtime.CompilerServices.VisualC.dll
        System.Runtime.dll
        System.Runtime.Extensions.dll
        System.Runtime.Handles.dll
        System.Runtime.InteropServices.dll
        System.Runtime.InteropServices.RuntimeInformation.dll
        System.Runtime.Intrinsics.dll
        System.Runtime.Loader.dll
        System.Runtime.Numerics.dll
        System.Runtime.Serialization.dll
        System.Runtime.Serialization.Formatters.dll
        System.Runtime.Serialization.Json.dll
        System.Runtime.Serialization.Primitives.dll
        System.Runtime.Serialization.Xml.dll
        System.Security.AccessControl.dll
        System.Security.Claims.dll
        System.Security.Cryptography.Algorithms.dll
        System.Security.Cryptography.Cng.dll
        System.Security.Cryptography.Csp.dll
        System.Security.Cryptography.Encoding.dll
        System.Security.Cryptography.OpenSsl.dll
        System.Security.Cryptography.Primitives.dll
        System.Security.Cryptography.X509Certificates.dll
        System.Security.dll
        System.Security.Principal.dll
        System.Security.Principal.Windows.dll
        System.Security.SecureString.dll
        System.ServiceModel.Web.dll
        System.ServiceProcess.dll
        System.Text.Encoding.CodePages.dll
        System.Text.Encoding.dll
        System.Text.Encoding.Extensions.dll
        System.Text.Encodings.Web.dll
        System.Text.Json.dll
        System.Text.RegularExpressions.dll
        System.Threading.Channels.dll
        System.Threading.dll
        System.Threading.Overlapped.dll
        System.Threading.Tasks.Dataflow.dll
        System.Threading.Tasks.dll
        System.Threading.Tasks.Extensions.dll
        System.Threading.Tasks.Parallel.dll
        System.Threading.Thread.dll
        System.Threading.ThreadPool.dll
        System.Threading.Timer.dll
        System.Transactions.dll
        System.Transactions.Local.dll
        System.ValueTuple.dll
        System.Web.dll
        System.Web.HttpUtility.dll
        System.Windows.dll
        System.Xml.dll
        System.Xml.Linq.dll
        System.Xml.ReaderWriter.dll
        System.Xml.Serialization.dll
        System.Xml.XDocument.dll
        System.Xml.XmlDocument.dll
        System.Xml.XmlSerializer.dll
        System.Xml.XPath.dll
        System.Xml.XPath.XDocument.dll
        Terriflux.deps.json
        Terriflux.dll
        Terriflux.pdb
        Terriflux.runtimeconfig.json
        WindowsBase.dll
```

#### __Projet dev__
```txt 
Terriflux
|   .gitattributes
|   .gitignore
|   export_presets.cfg
|   icon.svg
|   icon.svg.import
|   project.godot
|   Terriflux.csproj
|   Terriflux.sln
|
+---.godot
|   |   .gdignore
|   |   export_credentials.cfg
|   |   global_script_class_cache.cfg
|   |   uid_cache.bin
|   |
|   +---editor
|   |       Alert.cs-folding-81ec745299f676d46bdd00f827934416.cfg
|   |       Alert.tscn-editstate-734265966ebf55830e6134a212ff09f8.cfg
|   |       Alert.tscn-folding-734265966ebf55830e6134a212ff09f8.cfg
|   |       Bakery.cs-folding-0ba1b8ac2d45cbd62277c1ffdf8d7f2d.cfg
|   |       Bakery.tscn-editstate-f600b51b96efa4fe0aaee18657c47b0e.cfg
|   |       Bakery.tscn-folding-f600b51b96efa4fe0aaee18657c47b0e.cfg
|   |       Born2bSportyV2.ttf-3cea6c5d1d6119eba9e49136207a7716.fontdata-folding-cac0f4940b30eb0ee2441f69cf87f493.cfg
|   |       Born2bSportyV2.ttf-db0a69277372be920667874623f477db.fontdata-folding-1fcb946bf3ce73c774bf3d400c14a7a0.cfg
|   |       Building.cs-folding-3ac08fbbcde222c25e9ece2ab5364319.cfg
|   |       Building.tscn-editstate-3116578dc9ae7fef30eec6c764797be9.cfg
|   |       Building.tscn-folding-3116578dc9ae7fef30eec6c764797be9.cfg
|   |       BuildingFactory.cs-folding-1744d745cac8d635dacdf00ccef5c733.cfg
|   |       Cell.cs-folding-547c676af263ab28d91c8193ae464eb9.cfg
|   |       Cell.cs-folding-e146873750e66b470dab94c4525ed4ad.cfg
|   |       Cell.tscn-editstate-f474ca0db1ab635ce25a00fd86992491.cfg
|   |       Cell.tscn-folding-f474ca0db1ab635ce25a00fd86992491.cfg
|   |       create_recent.Node
|   |       EcologyGauge.cs-folding-c2af78600a05812efe4f8735c80e4be6.cfg
|   |       EcologyGauge.tscn-editstate-b9add31174de680f82f9ab15d8aa5356.cfg
|   |       EcologyGauge.tscn-folding-b9add31174de680f82f9ab15d8aa5356.cfg
|   |       EconomyGauge.cs-folding-7975f62aa7cb498ca75570dc8267444c.cfg
|   |       EconomyGauge.tscn-editstate-0f3aba6af687ce50c2aa303606bc9135.cfg
|   |       EconomyGauge.tscn-folding-0f3aba6af687ce50c2aa303606bc9135.cfg
|   |       editor_layout.cfg
|   |       End.cs-folding-4682033edced4c844200b4b3d7d933f7.cfg
|   |       End.cs-folding-81fcba6b4c09f18275f99df8a6e5b073.cfg
|   |       End.tscn-editstate-4809d80f9c601fc8dd36012d3fdd8cd2.cfg
|   |       End.tscn-folding-4809d80f9c601fc8dd36012d3fdd8cd2.cfg
|   |       EnergyGauge.cs-folding-37b577ff20092504a86c5a185e598620.cfg
|   |       EnergyGauge.tscn-editstate-fe966bd70c85fbab5027f62c6de5b96f.cfg
|   |       EnergyGauge.tscn-folding-fe966bd70c85fbab5027f62c6de5b96f.cfg
|   |       EnergySupplier.cs-folding-a8ae3df8c32bcc301725f40491e72b21.cfg
|   |       EnergySupplier.tscn-editstate-ab473c0e5eba334c13626479b44e5116.cfg
|   |       EnergySupplier.tscn-folding-ab473c0e5eba334c13626479b44e5116.cfg
|   |       export-0f3aba6af687ce50c2aa303606bc9135-EconomyGauge.scn-folding-ff0eeb21efbfbe3f78a8c5cfd93d4dec.cfg
|   |       export-1492b34c78d9d8ab54a52060768c172c-Gauge.scn-folding-7b7628fa406d2b16fe04a30203c8007c.cfg
|   |       export-1624c0e3350d1cfa09a00cd86b8ddb98-Factory.scn-folding-a34710acb7e36789ede7d8d7e2a494e6.cfg
|   |       export-26da9b8ee0db6aca673cec2ec76c2f7d-RawNode.scn-folding-b6ea2edafc6729b882b431ae59c7f307.cfg
|   |       export-2783464680ca488868fbd5f44862941a-SocialGauge.scn-folding-e967f87483dbd49eb569ba179d6c5d79.cfg
|   |       export-30d07965ac44c2fb99ab9f50d00e9916-Impacts.scn-folding-1ecb5dcee83d9c994045064e1cadab8d.cfg
|   |       export-3116578dc9ae7fef30eec6c764797be9-Building.scn-folding-cc20e58e4282c2686bad40124ace8fd9.cfg
|   |       export-3b73e551df68b342fd5f8ef2cec6fcbf-Shaft.scn-folding-86b6e9bb81b2ed7e8e520a9980235bf5.cfg
|   |       export-3bb6eef5f90d4c85390e40fa7fca95a8-Grocery.scn-folding-0bb2f14031ebeb0a8164ad1f0729fde8.cfg
|   |       export-4809d80f9c601fc8dd36012d3fdd8cd2-End.scn-folding-9d3cf1721627fed7be65a4379c2f97db.cfg
|   |       export-4f5a777d9f4557d53260faa7a083b510-Grass.scn-folding-5b67b90d56b24afb18e893afb2a0e54c.cfg
|   |       export-53dbb6a3d72946430c5d7a171c464c47-PlacementList.scn-folding-cfaf09840054c87b21a019607441f9b7.cfg
|   |       export-734265966ebf55830e6134a212ff09f8-Alert.scn-folding-1d9b3931183cebf04eb810ab7bdc3bf9.cfg
|   |       export-8d2a394058e120f57ffe81cd3728e7ad-Grid.scn-folding-c4544c68088ea0ce8fce7194d04a0786.cfg
|   |       export-9b3e9012c98db2d88c40ec50085cc696-Warehouse.scn-folding-e8a8e20681015f3f8bd49f18670a61cb.cfg
|   |       export-ab473c0e5eba334c13626479b44e5116-EnergySupplier.scn-folding-7a7a67b5902bca73502e613ec193fa23.cfg
|   |       export-b59783b1a03a1b1e91a10008f62c5d6c-Round.scn-folding-33111c7bc0100dbd7aa186cdc0d99064.cfg
|   |       export-b9add31174de680f82f9ab15d8aa5356-EcologyGauge.scn-folding-f9c410eb00c5ece6ff58bb05165c7ff3.cfg
|   |       export-c923ca9f4edc7b17c5f5b7fdaf092d0a-Inventory.scn-folding-45748b2381819d3e892ed57e5fbbefc9.cfg
|   |       export-cdcb0acb5e2cadd8cd8da526fd5181de-MainScene.scn-folding-fae6146dd0a3f4620f353431c00b5cfd.cfg
|   |       export-e33461b533cf0c8ea065484c5ab07125-Field.scn-folding-6b779ddbb1bf88aafb1434fd6cc5ee87.cfg
|   |       export-f474ca0db1ab635ce25a00fd86992491-Cell.scn-folding-9e35d091c8a7883b81bb85b4edc1cec7.cfg
|   |       export-f600b51b96efa4fe0aaee18657c47b0e-Bakery.scn-folding-c00ee054a52e8926193ef03e224140cc.cfg
|   |       Factory.cs-folding-2124e4e0e3b67aec56c76afeeb69391a.cfg
|   |       Factory.tscn-editstate-1624c0e3350d1cfa09a00cd86b8ddb98.cfg
|   |       Factory.tscn-folding-1624c0e3350d1cfa09a00cd86b8ddb98.cfg
|   |       favorites
|   |       favorites.Node
|   |       Field.cs-folding-e164f638be0461e459db344ed1408cb7.cfg
|   |       Field.tscn-editstate-e33461b533cf0c8ea065484c5ab07125.cfg
|   |       Field.tscn-folding-e33461b533cf0c8ea065484c5ab07125.cfg
|   |       filesystem_cache8
|   |       filesystem_update4
|   |       Gauge.cs-folding-c8d6f867ee6c51f1f04822bd77409917.cfg
|   |       Gauge.tscn-editstate-1492b34c78d9d8ab54a52060768c172c.cfg
|   |       Gauge.tscn-folding-1492b34c78d9d8ab54a52060768c172c.cfg
|   |       Grass.cs-folding-2789815f9bd541aad13e44e6e780dadd.cfg
|   |       Grass.tscn-editstate-4f5a777d9f4557d53260faa7a083b510.cfg
|   |       Grass.tscn-folding-4f5a777d9f4557d53260faa7a083b510.cfg
|   |       Grid.cs-folding-619772fe8bc7a1f91b9dbbc5cb8b1b2d.cfg
|   |       Grid.tscn-editstate-8d2a394058e120f57ffe81cd3728e7ad.cfg
|   |       Grid.tscn-folding-8d2a394058e120f57ffe81cd3728e7ad.cfg
|   |       Grocery.cs-folding-1e19143ccbbcc00463de731411e78a49.cfg
|   |       Grocery.tscn-editstate-3bb6eef5f90d4c85390e40fa7fca95a8.cfg
|   |       Grocery.tscn-folding-3bb6eef5f90d4c85390e40fa7fca95a8.cfg
|   |       IAlert.cs-folding-0d0fc8cd046431e6859747b3033f5e36.cfg
|   |       IAlert.gd-folding-84b982b890e4426fc32897eb46017407.cfg
|   |       Impacts.cs-folding-66ba4359d85fcfe7273fdfefb7fca7b2.cfg
|   |       Impacts.tscn-editstate-30d07965ac44c2fb99ab9f50d00e9916.cfg
|   |       Impacts.tscn-folding-30d07965ac44c2fb99ab9f50d00e9916.cfg
|   |       Inventaire.tscn-editstate-4abd8c392ec055c820cf5be442f7177b.cfg
|   |       Inventaire.tscn-folding-4abd8c392ec055c820cf5be442f7177b.cfg
|   |       Inventory.cs-folding-c9c54164cf435ee025cb7ec96eff4ede.cfg
|   |       Inventory.tscn-editstate-c923ca9f4edc7b17c5f5b7fdaf092d0a.cfg
|   |       Inventory.tscn-folding-c923ca9f4edc7b17c5f5b7fdaf092d0a.cfg
|   |       IPlaceMediator.cs-folding-398720a6a59d1970284541d06869c736.cfg
|   |       MainScene.cs-folding-77a16669209154a62f233374565e0791.cfg
|   |       MainScene.tscn-editstate-cdcb0acb5e2cadd8cd8da526fd5181de.cfg
|   |       MainScene.tscn-folding-cdcb0acb5e2cadd8cd8da526fd5181de.cfg
|   |       PlaceMediator.cs-folding-43992e196a9b7dedfd461ad80957c3fb.cfg
|   |       PlacementList.cs-folding-4fd6b37bd9208db7c278cd5d81ed99a7.cfg
|   |       PlacementList.tscn-editstate-53dbb6a3d72946430c5d7a171c464c47.cfg
|   |       PlacementList.tscn-folding-53dbb6a3d72946430c5d7a171c464c47.cfg
|   |       project_metadata.cfg
|   |       RawNode.cs-folding-22d9f15f424070a30d5eb1fa25abfbd7.cfg
|   |       RawNode.tscn-editstate-26da9b8ee0db6aca673cec2ec76c2f7d.cfg
|   |       RawNode.tscn-editstate-c6f63a286184434565dc5bff3270ef00.cfg
|   |       RawNode.tscn-folding-26da9b8ee0db6aca673cec2ec76c2f7d.cfg
|   |       RawNode.tscn-folding-c6f63a286184434565dc5bff3270ef00.cfg
|   |       recent_dirs
|   |       Round.cs-folding-85498981353f337d2ae63018180a8524.cfg
|   |       Round.tscn-editstate-b59783b1a03a1b1e91a10008f62c5d6c.cfg
|   |       Round.tscn-folding-b59783b1a03a1b1e91a10008f62c5d6c.cfg
|   |       script_editor_cache.cfg
|   |       Shaft.cs-folding-511c38776e0d5cc6b69f459884fe16b4.cfg
|   |       Shaft.tscn-editstate-3b73e551df68b342fd5f8ef2cec6fcbf.cfg
|   |       Shaft.tscn-folding-3b73e551df68b342fd5f8ef2cec6fcbf.cfg
|   |       SocialGauge.cs-folding-81d565fc5896791db399b255880a798f.cfg
|   |       SocialGauge.tscn-editstate-2783464680ca488868fbd5f44862941a.cfg
|   |       SocialGauge.tscn-folding-2783464680ca488868fbd5f44862941a.cfg
|   |       Warehouse.cs-folding-5b1374178736ea1bdac23ab2ac9c9af7.cfg
|   |       Warehouse.tscn-editstate-9b3e9012c98db2d88c40ec50085cc696.cfg
|   |       Warehouse.tscn-folding-9b3e9012c98db2d88c40ec50085cc696.cfg
|   |
|   +---exported
|   |   \---133200997
|   |           export-0f3aba6af687ce50c2aa303606bc9135-EconomyGauge.scn
|   |           export-1492b34c78d9d8ab54a52060768c172c-Gauge.scn
|   |           export-1624c0e3350d1cfa09a00cd86b8ddb98-Factory.scn
|   |           export-26da9b8ee0db6aca673cec2ec76c2f7d-RawNode.scn
|   |           export-2783464680ca488868fbd5f44862941a-SocialGauge.scn
|   |           export-30d07965ac44c2fb99ab9f50d00e9916-Impacts.scn
|   |           export-3116578dc9ae7fef30eec6c764797be9-Building.scn
|   |           export-3b73e551df68b342fd5f8ef2cec6fcbf-Shaft.scn
|   |           export-3bb6eef5f90d4c85390e40fa7fca95a8-Grocery.scn
|   |           export-4809d80f9c601fc8dd36012d3fdd8cd2-End.scn
|   |           export-4f5a777d9f4557d53260faa7a083b510-Grass.scn
|   |           export-53dbb6a3d72946430c5d7a171c464c47-PlacementList.scn
|   |           export-734265966ebf55830e6134a212ff09f8-Alert.scn
|   |           export-8d2a394058e120f57ffe81cd3728e7ad-Grid.scn
|   |           export-9b3e9012c98db2d88c40ec50085cc696-Warehouse.scn
|   |           export-ab473c0e5eba334c13626479b44e5116-EnergySupplier.scn
|   |           export-b59783b1a03a1b1e91a10008f62c5d6c-Round.scn
|   |           export-b9add31174de680f82f9ab15d8aa5356-EcologyGauge.scn
|   |           export-c923ca9f4edc7b17c5f5b7fdaf092d0a-Inventory.scn
|   |           export-cdcb0acb5e2cadd8cd8da526fd5181de-MainScene.scn
|   |           export-e33461b533cf0c8ea065484c5ab07125-Field.scn
|   |           export-f474ca0db1ab635ce25a00fd86992491-Cell.scn
|   |           export-f600b51b96efa4fe0aaee18657c47b0e-Bakery.scn
|   |           file_cache
|   |
|   +---imported
|   |       alertbackground.png-ece3c635fd551bf5f9305d3935af4aac.ctex
|   |       alertbackground.png-ece3c635fd551bf5f9305d3935af4aac.md5
|   |       bakery.png-37208c83c1322fd5fa2246b23b8516b6.ctex
|   |       bakery.png-37208c83c1322fd5fa2246b23b8516b6.md5
|   |       Born2bSportyV2.ttf-3cea6c5d1d6119eba9e49136207a7716.fontdata
|   |       Born2bSportyV2.ttf-3cea6c5d1d6119eba9e49136207a7716.md5
|   |       Born2bSportyV2.ttf-db0a69277372be920667874623f477db.fontdata
|   |       Born2bSportyV2.ttf-db0a69277372be920667874623f477db.md5
|   |       complete_ecologygauge.png-a8123346a7071b7bec435b85e485e15b.ctex
|   |       complete_ecologygauge.png-a8123346a7071b7bec435b85e485e15b.md5
|   |       complete_economygauge.png-e5b5f9dcfff45801e32cdd6e239f2794.ctex
|   |       complete_economygauge.png-e5b5f9dcfff45801e32cdd6e239f2794.md5
|   |       complete_socialgauge.png-64daeff61438588130355fc046b7a789.ctex
|   |       complete_socialgauge.png-64daeff61438588130355fc046b7a789.md5
|   |       const.png-c72c519cc2d2ca727c2c9e923c991982.ctex
|   |       const.png-c72c519cc2d2ca727c2c9e923c991982.md5
|   |       cross.png-456b3dd849e460da5dac4e820fe01f1f.ctex
|   |       cross.png-456b3dd849e460da5dac4e820fe01f1f.md5
|   |       default.png-cdc049b277919bbd8a86537f1a8609e8.ctex
|   |       default.png-cdc049b277919bbd8a86537f1a8609e8.md5
|   |       down.png-47e6aedf3eef998e1fe1449fe7d155d0.ctex
|   |       down.png-47e6aedf3eef998e1fe1449fe7d155d0.md5
|   |       down_.png-9d5f0e63a1bcd852414f743b77ed7f00.ctex
|   |       down_.png-9d5f0e63a1bcd852414f743b77ed7f00.md5
|   |       emblem.png-3940a8cd2cac3c2934a24ebafad15e87.ctex
|   |       emblem.png-3940a8cd2cac3c2934a24ebafad15e87.md5
|   |       empty_gauge.png-8d79410bca80c63527521b3249a9e04d.ctex
|   |       empty_gauge.png-8d79410bca80c63527521b3249a9e04d.md5
|   |       energysupplier.png-055c644ab04227d71af1e52ccb46aa3c.ctex
|   |       energysupplier.png-055c644ab04227d71af1e52ccb46aa3c.md5
|   |       factory.png-933eea5347c7f6cdf077647c483fa034.ctex
|   |       factory.png-933eea5347c7f6cdf077647c483fa034.md5
|   |       fail.png-04bfcde6987168ca66cbc88c34208164.ctex
|   |       fail.png-04bfcde6987168ca66cbc88c34208164.md5
|   |       field.png-638bec4cc1b3ffc179c6bbec1709031a.ctex
|   |       field.png-638bec4cc1b3ffc179c6bbec1709031a.md5
|   |       grass.png-8fcfdb669f97c1c4ecc969834eca178e.ctex
|   |       grass.png-8fcfdb669f97c1c4ecc969834eca178e.md5
|   |       grocery.png-67adb82f9cfb46dc8c9dada30f919da6.ctex
|   |       grocery.png-67adb82f9cfb46dc8c9dada30f919da6.md5
|   |       Help.png-6c27ccbbe33b3c0e860d3aca17b6287e.ctex
|   |       Help.png-6c27ccbbe33b3c0e860d3aca17b6287e.md5
|   |       HelpHover.png-f5c177efb192294c3858c88a3be3fa78.ctex
|   |       HelpHover.png-f5c177efb192294c3858c88a3be3fa78.md5
|   |       hospital.png-e08a1d771e3f12336d8d7871f7282acf.ctex
|   |       hospital.png-e08a1d771e3f12336d8d7871f7282acf.md5
|   |       house.png-1af7e6cd768c9edd4ce63600429bbdc6.ctex
|   |       house.png-1af7e6cd768c9edd4ce63600429bbdc6.md5
|   |       icon.svg-218a8f2b3041327d8a5756f3a245f83b.ctex
|   |       icon.svg-218a8f2b3041327d8a5756f3a245f83b.md5
|   |       inventory.png-506eec3d4b44abadacf4bf4bdef78f08.ctex
|   |       inventory.png-506eec3d4b44abadacf4bf4bdef78f08.md5
|   |       inventorybutton.png-490e1919ee70eaabd99b640d387b79e9.ctex
|   |       inventorybutton.png-490e1919ee70eaabd99b640d387b79e9.md5
|   |       inventorybutton.png-53c3614a4aaadf960558ae5df2bd286a.ctex
|   |       inventorybutton.png-53c3614a4aaadf960558ae5df2bd286a.md5
|   |       leftclick.png-332b6a19e11729ef21229e42ff7f88a2.ctex
|   |       leftclick.png-332b6a19e11729ef21229e42ff7f88a2.md5
|   |       metallurgy.png-2bfbb6a98ae5e5386cc877a45818289f.ctex
|   |       metallurgy.png-2bfbb6a98ae5e5386cc877a45818289f.md5
|   |       next.png-041b8abc15cd34cfcf9587d65f70d1bc.ctex
|   |       next.png-041b8abc15cd34cfcf9587d65f70d1bc.md5
|   |       sawmill.png-f4498f2b94f4f3c942a0f2d3973756f3.ctex
|   |       sawmill.png-f4498f2b94f4f3c942a0f2d3973756f3.md5
|   |       shaft.png-32ac45417366df3f2a724f2b37d1fbb2.ctex
|   |       shaft.png-32ac45417366df3f2a724f2b37d1fbb2.md5
|   |       supplier.png-71cb785d260f7a543f7aefebf5ee546f.ctex
|   |       supplier.png-71cb785d260f7a543f7aefebf5ee546f.md5
|   |       up.png-ba79016fade351f944e9a032f53ca164.ctex
|   |       up.png-ba79016fade351f944e9a032f53ca164.md5
|   |       victory.png-3217a3e83d4f78d1aa29c1d67b1a02cf.ctex
|   |       victory.png-3217a3e83d4f78d1aa29c1d67b1a02cf.md5
|   |       warehouse.png-bddc368d5a959701d5c35219f84b7192.ctex
|   |       warehouse.png-bddc368d5a959701d5c35219f84b7192.md5
|   |       willchange.png-ad342b29430d64f6d4255bc3cc662ee5.ctex
|   |       willchange.png-ad342b29430d64f6d4255bc3cc662ee5.md5
|   |
|   +---mono
|   |   +---metadata
|   |   \---temp
|   |       +---bin
|   |       |   +---Debug
|   |       |   |       GodotSharp.dll
|   |       |   |       GodotSharpEditor.dll
|   |       |   |       Terriflux.deps.json
|   |       |   |       Terriflux.dll
|   |       |   |       Terriflux.pdb
|   |       |   |       Terriflux.runtimeconfig.json
|   |       |   |
|   |       |   \---ExportRelease
|   |       |       +---linux-x64
|   |       |       |       createdump
|   |       |       |       GodotSharp.dll
|   |       |       |       libclrjit.so
|   |       |       |       libcoreclr.so
|   |       |       |       libcoreclrtraceptprovider.so
|   |       |       |       libdbgshim.so
|   |       |       |       libhostfxr.so
|   |       |       |       libhostpolicy.so
|   |       |       |       libmscordaccore.so
|   |       |       |       libmscordbi.so
|   |       |       |       libSystem.Globalization.Native.so
|   |       |       |       libSystem.IO.Compression.Native.so
|   |       |       |       libSystem.Native.so
|   |       |       |       libSystem.Net.Security.Native.so
|   |       |       |       libSystem.Security.Cryptography.Native.OpenSsl.so
|   |       |       |       Microsoft.CSharp.dll
|   |       |       |       Microsoft.VisualBasic.Core.dll
|   |       |       |       Microsoft.VisualBasic.dll
|   |       |       |       Microsoft.Win32.Primitives.dll
|   |       |       |       Microsoft.Win32.Registry.dll
|   |       |       |       mscorlib.dll
|   |       |       |       netstandard.dll
|   |       |       |       System.AppContext.dll
|   |       |       |       System.Buffers.dll
|   |       |       |       System.Collections.Concurrent.dll
|   |       |       |       System.Collections.dll
|   |       |       |       System.Collections.Immutable.dll
|   |       |       |       System.Collections.NonGeneric.dll
|   |       |       |       System.Collections.Specialized.dll
|   |       |       |       System.ComponentModel.Annotations.dll
|   |       |       |       System.ComponentModel.DataAnnotations.dll
|   |       |       |       System.ComponentModel.dll
|   |       |       |       System.ComponentModel.EventBasedAsync.dll
|   |       |       |       System.ComponentModel.Primitives.dll
|   |       |       |       System.ComponentModel.TypeConverter.dll
|   |       |       |       System.Configuration.dll
|   |       |       |       System.Console.dll
|   |       |       |       System.Core.dll
|   |       |       |       System.Data.Common.dll
|   |       |       |       System.Data.DataSetExtensions.dll
|   |       |       |       System.Data.dll
|   |       |       |       System.Diagnostics.Contracts.dll
|   |       |       |       System.Diagnostics.Debug.dll
|   |       |       |       System.Diagnostics.DiagnosticSource.dll
|   |       |       |       System.Diagnostics.FileVersionInfo.dll
|   |       |       |       System.Diagnostics.Process.dll
|   |       |       |       System.Diagnostics.StackTrace.dll
|   |       |       |       System.Diagnostics.TextWriterTraceListener.dll
|   |       |       |       System.Diagnostics.Tools.dll
|   |       |       |       System.Diagnostics.TraceSource.dll
|   |       |       |       System.Diagnostics.Tracing.dll
|   |       |       |       System.dll
|   |       |       |       System.Drawing.dll
|   |       |       |       System.Drawing.Primitives.dll
|   |       |       |       System.Dynamic.Runtime.dll
|   |       |       |       System.Formats.Asn1.dll
|   |       |       |       System.Globalization.Calendars.dll
|   |       |       |       System.Globalization.dll
|   |       |       |       System.Globalization.Extensions.dll
|   |       |       |       System.IO.Compression.Brotli.dll
|   |       |       |       System.IO.Compression.dll
|   |       |       |       System.IO.Compression.FileSystem.dll
|   |       |       |       System.IO.Compression.ZipFile.dll
|   |       |       |       System.IO.dll
|   |       |       |       System.IO.FileSystem.AccessControl.dll
|   |       |       |       System.IO.FileSystem.dll
|   |       |       |       System.IO.FileSystem.DriveInfo.dll
|   |       |       |       System.IO.FileSystem.Primitives.dll
|   |       |       |       System.IO.FileSystem.Watcher.dll
|   |       |       |       System.IO.IsolatedStorage.dll
|   |       |       |       System.IO.MemoryMappedFiles.dll
|   |       |       |       System.IO.Pipes.AccessControl.dll
|   |       |       |       System.IO.Pipes.dll
|   |       |       |       System.IO.UnmanagedMemoryStream.dll
|   |       |       |       System.Linq.dll
|   |       |       |       System.Linq.Expressions.dll
|   |       |       |       System.Linq.Parallel.dll
|   |       |       |       System.Linq.Queryable.dll
|   |       |       |       System.Memory.dll
|   |       |       |       System.Net.dll
|   |       |       |       System.Net.Http.dll
|   |       |       |       System.Net.Http.Json.dll
|   |       |       |       System.Net.HttpListener.dll
|   |       |       |       System.Net.Mail.dll
|   |       |       |       System.Net.NameResolution.dll
|   |       |       |       System.Net.NetworkInformation.dll
|   |       |       |       System.Net.Ping.dll
|   |       |       |       System.Net.Primitives.dll
|   |       |       |       System.Net.Quic.dll
|   |       |       |       System.Net.Requests.dll
|   |       |       |       System.Net.Security.dll
|   |       |       |       System.Net.ServicePoint.dll
|   |       |       |       System.Net.Sockets.dll
|   |       |       |       System.Net.WebClient.dll
|   |       |       |       System.Net.WebHeaderCollection.dll
|   |       |       |       System.Net.WebProxy.dll
|   |       |       |       System.Net.WebSockets.Client.dll
|   |       |       |       System.Net.WebSockets.dll
|   |       |       |       System.Numerics.dll
|   |       |       |       System.Numerics.Vectors.dll
|   |       |       |       System.ObjectModel.dll
|   |       |       |       System.Private.CoreLib.dll
|   |       |       |       System.Private.DataContractSerialization.dll
|   |       |       |       System.Private.Uri.dll
|   |       |       |       System.Private.Xml.dll
|   |       |       |       System.Private.Xml.Linq.dll
|   |       |       |       System.Reflection.DispatchProxy.dll
|   |       |       |       System.Reflection.dll
|   |       |       |       System.Reflection.Emit.dll
|   |       |       |       System.Reflection.Emit.ILGeneration.dll
|   |       |       |       System.Reflection.Emit.Lightweight.dll
|   |       |       |       System.Reflection.Extensions.dll
|   |       |       |       System.Reflection.Metadata.dll
|   |       |       |       System.Reflection.Primitives.dll
|   |       |       |       System.Reflection.TypeExtensions.dll
|   |       |       |       System.Resources.Reader.dll
|   |       |       |       System.Resources.ResourceManager.dll
|   |       |       |       System.Resources.Writer.dll
|   |       |       |       System.Runtime.CompilerServices.Unsafe.dll
|   |       |       |       System.Runtime.CompilerServices.VisualC.dll
|   |       |       |       System.Runtime.dll
|   |       |       |       System.Runtime.Extensions.dll
|   |       |       |       System.Runtime.Handles.dll
|   |       |       |       System.Runtime.InteropServices.dll
|   |       |       |       System.Runtime.InteropServices.RuntimeInformation.dll
|   |       |       |       System.Runtime.Intrinsics.dll
|   |       |       |       System.Runtime.Loader.dll
|   |       |       |       System.Runtime.Numerics.dll
|   |       |       |       System.Runtime.Serialization.dll
|   |       |       |       System.Runtime.Serialization.Formatters.dll
|   |       |       |       System.Runtime.Serialization.Json.dll
|   |       |       |       System.Runtime.Serialization.Primitives.dll
|   |       |       |       System.Runtime.Serialization.Xml.dll
|   |       |       |       System.Security.AccessControl.dll
|   |       |       |       System.Security.Claims.dll
|   |       |       |       System.Security.Cryptography.Algorithms.dll
|   |       |       |       System.Security.Cryptography.Cng.dll
|   |       |       |       System.Security.Cryptography.Csp.dll
|   |       |       |       System.Security.Cryptography.Encoding.dll
|   |       |       |       System.Security.Cryptography.OpenSsl.dll
|   |       |       |       System.Security.Cryptography.Primitives.dll
|   |       |       |       System.Security.Cryptography.X509Certificates.dll
|   |       |       |       System.Security.dll
|   |       |       |       System.Security.Principal.dll
|   |       |       |       System.Security.Principal.Windows.dll
|   |       |       |       System.Security.SecureString.dll
|   |       |       |       System.ServiceModel.Web.dll
|   |       |       |       System.ServiceProcess.dll
|   |       |       |       System.Text.Encoding.CodePages.dll
|   |       |       |       System.Text.Encoding.dll
|   |       |       |       System.Text.Encoding.Extensions.dll
|   |       |       |       System.Text.Encodings.Web.dll
|   |       |       |       System.Text.Json.dll
|   |       |       |       System.Text.RegularExpressions.dll
|   |       |       |       System.Threading.Channels.dll
|   |       |       |       System.Threading.dll
|   |       |       |       System.Threading.Overlapped.dll
|   |       |       |       System.Threading.Tasks.Dataflow.dll
|   |       |       |       System.Threading.Tasks.dll
|   |       |       |       System.Threading.Tasks.Extensions.dll
|   |       |       |       System.Threading.Tasks.Parallel.dll
|   |       |       |       System.Threading.Thread.dll
|   |       |       |       System.Threading.ThreadPool.dll
|   |       |       |       System.Threading.Timer.dll
|   |       |       |       System.Transactions.dll
|   |       |       |       System.Transactions.Local.dll
|   |       |       |       System.ValueTuple.dll
|   |       |       |       System.Web.dll
|   |       |       |       System.Web.HttpUtility.dll
|   |       |       |       System.Windows.dll
|   |       |       |       System.Xml.dll
|   |       |       |       System.Xml.Linq.dll
|   |       |       |       System.Xml.ReaderWriter.dll
|   |       |       |       System.Xml.Serialization.dll
|   |       |       |       System.Xml.XDocument.dll
|   |       |       |       System.Xml.XmlDocument.dll
|   |       |       |       System.Xml.XmlSerializer.dll
|   |       |       |       System.Xml.XPath.dll
|   |       |       |       System.Xml.XPath.XDocument.dll
|   |       |       |       Terriflux.deps.json
|   |       |       |       Terriflux.dll
|   |       |       |       Terriflux.pdb
|   |       |       |       Terriflux.runtimeconfig.json
|   |       |       |       WindowsBase.dll
|   |       |       |
|   |       |       \---win-x64
|   |       |               api-ms-win-core-console-l1-1-0.dll
|   |       |               api-ms-win-core-console-l1-2-0.dll
|   |       |               api-ms-win-core-datetime-l1-1-0.dll
|   |       |               api-ms-win-core-debug-l1-1-0.dll
|   |       |               api-ms-win-core-errorhandling-l1-1-0.dll
|   |       |               api-ms-win-core-fibers-l1-1-0.dll
|   |       |               api-ms-win-core-file-l1-1-0.dll
|   |       |               api-ms-win-core-file-l1-2-0.dll
|   |       |               api-ms-win-core-file-l2-1-0.dll
|   |       |               api-ms-win-core-handle-l1-1-0.dll
|   |       |               api-ms-win-core-heap-l1-1-0.dll
|   |       |               api-ms-win-core-interlocked-l1-1-0.dll
|   |       |               api-ms-win-core-libraryloader-l1-1-0.dll
|   |       |               api-ms-win-core-localization-l1-2-0.dll
|   |       |               api-ms-win-core-memory-l1-1-0.dll
|   |       |               api-ms-win-core-namedpipe-l1-1-0.dll
|   |       |               api-ms-win-core-processenvironment-l1-1-0.dll
|   |       |               api-ms-win-core-processthreads-l1-1-0.dll
|   |       |               api-ms-win-core-processthreads-l1-1-1.dll
|   |       |               api-ms-win-core-profile-l1-1-0.dll
|   |       |               api-ms-win-core-rtlsupport-l1-1-0.dll
|   |       |               api-ms-win-core-string-l1-1-0.dll
|   |       |               api-ms-win-core-synch-l1-1-0.dll
|   |       |               api-ms-win-core-synch-l1-2-0.dll
|   |       |               api-ms-win-core-sysinfo-l1-1-0.dll
|   |       |               api-ms-win-core-timezone-l1-1-0.dll
|   |       |               api-ms-win-core-util-l1-1-0.dll
|   |       |               api-ms-win-crt-conio-l1-1-0.dll
|   |       |               api-ms-win-crt-convert-l1-1-0.dll
|   |       |               api-ms-win-crt-environment-l1-1-0.dll
|   |       |               api-ms-win-crt-filesystem-l1-1-0.dll
|   |       |               api-ms-win-crt-heap-l1-1-0.dll
|   |       |               api-ms-win-crt-locale-l1-1-0.dll
|   |       |               api-ms-win-crt-math-l1-1-0.dll
|   |       |               api-ms-win-crt-multibyte-l1-1-0.dll
|   |       |               api-ms-win-crt-private-l1-1-0.dll
|   |       |               api-ms-win-crt-process-l1-1-0.dll
|   |       |               api-ms-win-crt-runtime-l1-1-0.dll
|   |       |               api-ms-win-crt-stdio-l1-1-0.dll
|   |       |               api-ms-win-crt-string-l1-1-0.dll
|   |       |               api-ms-win-crt-time-l1-1-0.dll
|   |       |               api-ms-win-crt-utility-l1-1-0.dll
|   |       |               clretwrc.dll
|   |       |               clrjit.dll
|   |       |               coreclr.dll
|   |       |               createdump.exe
|   |       |               dbgshim.dll
|   |       |               GodotSharp.dll
|   |       |               hostfxr.dll
|   |       |               hostpolicy.dll
|   |       |               Microsoft.CSharp.dll
|   |       |               Microsoft.DiaSymReader.Native.amd64.dll
|   |       |               Microsoft.VisualBasic.Core.dll
|   |       |               Microsoft.VisualBasic.dll
|   |       |               Microsoft.Win32.Primitives.dll
|   |       |               Microsoft.Win32.Registry.dll
|   |       |               mscordaccore.dll
|   |       |               mscordaccore_amd64_amd64_6.0.2423.51814.dll
|   |       |               mscordbi.dll
|   |       |               mscorlib.dll
|   |       |               mscorrc.dll
|   |       |               msquic.dll
|   |       |               netstandard.dll
|   |       |               System.AppContext.dll
|   |       |               System.Buffers.dll
|   |       |               System.Collections.Concurrent.dll
|   |       |               System.Collections.dll
|   |       |               System.Collections.Immutable.dll
|   |       |               System.Collections.NonGeneric.dll
|   |       |               System.Collections.Specialized.dll
|   |       |               System.ComponentModel.Annotations.dll
|   |       |               System.ComponentModel.DataAnnotations.dll
|   |       |               System.ComponentModel.dll
|   |       |               System.ComponentModel.EventBasedAsync.dll
|   |       |               System.ComponentModel.Primitives.dll
|   |       |               System.ComponentModel.TypeConverter.dll
|   |       |               System.Configuration.dll
|   |       |               System.Console.dll
|   |       |               System.Core.dll
|   |       |               System.Data.Common.dll
|   |       |               System.Data.DataSetExtensions.dll
|   |       |               System.Data.dll
|   |       |               System.Diagnostics.Contracts.dll
|   |       |               System.Diagnostics.Debug.dll
|   |       |               System.Diagnostics.DiagnosticSource.dll
|   |       |               System.Diagnostics.FileVersionInfo.dll
|   |       |               System.Diagnostics.Process.dll
|   |       |               System.Diagnostics.StackTrace.dll
|   |       |               System.Diagnostics.TextWriterTraceListener.dll
|   |       |               System.Diagnostics.Tools.dll
|   |       |               System.Diagnostics.TraceSource.dll
|   |       |               System.Diagnostics.Tracing.dll
|   |       |               System.dll
|   |       |               System.Drawing.dll
|   |       |               System.Drawing.Primitives.dll
|   |       |               System.Dynamic.Runtime.dll
|   |       |               System.Formats.Asn1.dll
|   |       |               System.Globalization.Calendars.dll
|   |       |               System.Globalization.dll
|   |       |               System.Globalization.Extensions.dll
|   |       |               System.IO.Compression.Brotli.dll
|   |       |               System.IO.Compression.dll
|   |       |               System.IO.Compression.FileSystem.dll
|   |       |               System.IO.Compression.Native.dll
|   |       |               System.IO.Compression.ZipFile.dll
|   |       |               System.IO.dll
|   |       |               System.IO.FileSystem.AccessControl.dll
|   |       |               System.IO.FileSystem.dll
|   |       |               System.IO.FileSystem.DriveInfo.dll
|   |       |               System.IO.FileSystem.Primitives.dll
|   |       |               System.IO.FileSystem.Watcher.dll
|   |       |               System.IO.IsolatedStorage.dll
|   |       |               System.IO.MemoryMappedFiles.dll
|   |       |               System.IO.Pipes.AccessControl.dll
|   |       |               System.IO.Pipes.dll
|   |       |               System.IO.UnmanagedMemoryStream.dll
|   |       |               System.Linq.dll
|   |       |               System.Linq.Expressions.dll
|   |       |               System.Linq.Parallel.dll
|   |       |               System.Linq.Queryable.dll
|   |       |               System.Memory.dll
|   |       |               System.Net.dll
|   |       |               System.Net.Http.dll
|   |       |               System.Net.Http.Json.dll
|   |       |               System.Net.HttpListener.dll
|   |       |               System.Net.Mail.dll
|   |       |               System.Net.NameResolution.dll
|   |       |               System.Net.NetworkInformation.dll
|   |       |               System.Net.Ping.dll
|   |       |               System.Net.Primitives.dll
|   |       |               System.Net.Quic.dll
|   |       |               System.Net.Requests.dll
|   |       |               System.Net.Security.dll
|   |       |               System.Net.ServicePoint.dll
|   |       |               System.Net.Sockets.dll
|   |       |               System.Net.WebClient.dll
|   |       |               System.Net.WebHeaderCollection.dll
|   |       |               System.Net.WebProxy.dll
|   |       |               System.Net.WebSockets.Client.dll
|   |       |               System.Net.WebSockets.dll
|   |       |               System.Numerics.dll
|   |       |               System.Numerics.Vectors.dll
|   |       |               System.ObjectModel.dll
|   |       |               System.Private.CoreLib.dll
|   |       |               System.Private.DataContractSerialization.dll
|   |       |               System.Private.Uri.dll
|   |       |               System.Private.Xml.dll
|   |       |               System.Private.Xml.Linq.dll
|   |       |               System.Reflection.DispatchProxy.dll
|   |       |               System.Reflection.dll
|   |       |               System.Reflection.Emit.dll
|   |       |               System.Reflection.Emit.ILGeneration.dll
|   |       |               System.Reflection.Emit.Lightweight.dll
|   |       |               System.Reflection.Extensions.dll
|   |       |               System.Reflection.Metadata.dll
|   |       |               System.Reflection.Primitives.dll
|   |       |               System.Reflection.TypeExtensions.dll
|   |       |               System.Resources.Reader.dll
|   |       |               System.Resources.ResourceManager.dll
|   |       |               System.Resources.Writer.dll
|   |       |               System.Runtime.CompilerServices.Unsafe.dll
|   |       |               System.Runtime.CompilerServices.VisualC.dll
|   |       |               System.Runtime.dll
|   |       |               System.Runtime.Extensions.dll
|   |       |               System.Runtime.Handles.dll
|   |       |               System.Runtime.InteropServices.dll
|   |       |               System.Runtime.InteropServices.RuntimeInformation.dll
|   |       |               System.Runtime.Intrinsics.dll
|   |       |               System.Runtime.Loader.dll
|   |       |               System.Runtime.Numerics.dll
|   |       |               System.Runtime.Serialization.dll
|   |       |               System.Runtime.Serialization.Formatters.dll
|   |       |               System.Runtime.Serialization.Json.dll
|   |       |               System.Runtime.Serialization.Primitives.dll
|   |       |               System.Runtime.Serialization.Xml.dll
|   |       |               System.Security.AccessControl.dll
|   |       |               System.Security.Claims.dll
|   |       |               System.Security.Cryptography.Algorithms.dll
|   |       |               System.Security.Cryptography.Cng.dll
|   |       |               System.Security.Cryptography.Csp.dll
|   |       |               System.Security.Cryptography.Encoding.dll
|   |       |               System.Security.Cryptography.OpenSsl.dll
|   |       |               System.Security.Cryptography.Primitives.dll
|   |       |               System.Security.Cryptography.X509Certificates.dll
|   |       |               System.Security.dll
|   |       |               System.Security.Principal.dll
|   |       |               System.Security.Principal.Windows.dll
|   |       |               System.Security.SecureString.dll
|   |       |               System.ServiceModel.Web.dll
|   |       |               System.ServiceProcess.dll
|   |       |               System.Text.Encoding.CodePages.dll
|   |       |               System.Text.Encoding.dll
|   |       |               System.Text.Encoding.Extensions.dll
|   |       |               System.Text.Encodings.Web.dll
|   |       |               System.Text.Json.dll
|   |       |               System.Text.RegularExpressions.dll
|   |       |               System.Threading.Channels.dll
|   |       |               System.Threading.dll
|   |       |               System.Threading.Overlapped.dll
|   |       |               System.Threading.Tasks.Dataflow.dll
|   |       |               System.Threading.Tasks.dll
|   |       |               System.Threading.Tasks.Extensions.dll
|   |       |               System.Threading.Tasks.Parallel.dll
|   |       |               System.Threading.Thread.dll
|   |       |               System.Threading.ThreadPool.dll
|   |       |               System.Threading.Timer.dll
|   |       |               System.Transactions.dll
|   |       |               System.Transactions.Local.dll
|   |       |               System.ValueTuple.dll
|   |       |               System.Web.dll
|   |       |               System.Web.HttpUtility.dll
|   |       |               System.Windows.dll
|   |       |               System.Xml.dll
|   |       |               System.Xml.Linq.dll
|   |       |               System.Xml.ReaderWriter.dll
|   |       |               System.Xml.Serialization.dll
|   |       |               System.Xml.XDocument.dll
|   |       |               System.Xml.XmlDocument.dll
|   |       |               System.Xml.XmlSerializer.dll
|   |       |               System.Xml.XPath.dll
|   |       |               System.Xml.XPath.XDocument.dll
|   |       |               Terriflux.deps.json
|   |       |               Terriflux.dll
|   |       |               Terriflux.pdb
|   |       |               Terriflux.runtimeconfig.json
|   |       |               ucrtbase.dll
|   |       |               WindowsBase.dll
|   |       |
|   |       \---obj
|   |           |   project.assets.json
|   |           |   project.nuget.cache
|   |           |   Terriflux.csproj.nuget.dgspec.json
|   |           |   Terriflux.csproj.nuget.g.props
|   |           |   Terriflux.csproj.nuget.g.targets
|   |           |
|   |           +---Debug
|   |           |   |   .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
|   |           |   |   Terriflux.AssemblyInfo.cs
|   |           |   |   Terriflux.AssemblyInfoInputs.cache
|   |           |   |   Terriflux.assets.cache
|   |           |   |   Terriflux.csproj.AssemblyReference.cache
|   |           |   |   Terriflux.csproj.CopyComplete
|   |           |   |   Terriflux.csproj.CoreCompileInputs.cache
|   |           |   |   Terriflux.csproj.FileListAbsolute.txt
|   |           |   |   Terriflux.dll
|   |           |   |   Terriflux.GeneratedMSBuildEditorConfig.editorconfig
|   |           |   |   Terriflux.genruntimeconfig.cache
|   |           |   |   Terriflux.pdb
|   |           |   |
|   |           |   +---ref
|   |           |   |       Terriflux.dll
|   |           |   |
|   |           |   \---refint
|   |           |           Terriflux.dll
|   |           |
|   |           \---ExportRelease
|   |               +---linux-x64
|   |               |   |   .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
|   |               |   |   PublishOutputs.08c256da8b.txt
|   |               |   |   PublishOutputs.2d0c60b230.txt
|   |               |   |   PublishOutputs.70314f39ff.txt
|   |               |   |   Terriflux.AssemblyInfo.cs
|   |               |   |   Terriflux.AssemblyInfoInputs.cache
|   |               |   |   Terriflux.assets.cache
|   |               |   |   Terriflux.csproj.AssemblyReference.cache
|   |               |   |   Terriflux.csproj.CopyComplete
|   |               |   |   Terriflux.csproj.CoreCompileInputs.cache
|   |               |   |   Terriflux.csproj.FileListAbsolute.txt
|   |               |   |   Terriflux.dll
|   |               |   |   Terriflux.GeneratedMSBuildEditorConfig.editorconfig
|   |               |   |   Terriflux.genruntimeconfig.cache
|   |               |   |   Terriflux.pdb
|   |               |   |
|   |               |   +---ref
|   |               |   |       Terriflux.dll
|   |               |   |
|   |               |   \---refint
|   |               |           Terriflux.dll
|   |               |
|   |               \---win-x64
|   |                   |   .NETCoreApp,Version=v6.0.AssemblyAttributes.cs
|   |                   |   PublishOutputs.62119751cc.txt
|   |                   |   PublishOutputs.c6bdafe5ef.txt
|   |                   |   PublishOutputs.fec2e6f5cd.txt
|   |                   |   Terriflux.AssemblyInfo.cs
|   |                   |   Terriflux.AssemblyInfoInputs.cache
|   |                   |   Terriflux.assets.cache
|   |                   |   Terriflux.csproj.AssemblyReference.cache
|   |                   |   Terriflux.csproj.CopyComplete
|   |                   |   Terriflux.csproj.CoreCompileInputs.cache
|   |                   |   Terriflux.csproj.FileListAbsolute.txt
|   |                   |   Terriflux.dll
|   |                   |   Terriflux.GeneratedMSBuildEditorConfig.editorconfig
|   |                   |   Terriflux.genruntimeconfig.cache
|   |                   |   Terriflux.pdb
|   |                   |
|   |                   +---ref
|   |                   |       Terriflux.dll
|   |                   |
|   |                   \---refint
|   |                           Terriflux.dll
|   |
|   \---shader_cache
|       +---CanvasOcclusionShaderGLES3
|       |   \---968915a469db9a7d505be274e8060c8288c15a5865baeb8362b3b0e2cacb16f3
|       +---CanvasSdfShaderGLES3
|       |   \---72cda41890bce2f09217c172023d31e735a3fee605bad83c8e63f1a981a36a77
|       +---CanvasShaderGLES3
|       |   \---007cddfcf35f7d57b219cffec53f6a7d9fe7a1979be4db64c6450cfac6000053
|       |           0569298c4bd67f71fa194e93b48a113d8bfd63e0.cache
|       |           396754a90b2c72001e95dae76833f5921ec9fe33.cache
|       |
|       +---CopyShaderGLES3
|       |   \---b1bc5a355ed9bda23f291956f121e0535b4e81b54cdac398412d200e6133161f
|       |           0569298c4bd67f71fa194e93b48a113d8bfd63e0.cache
|       |
|       +---CubemapFilterShaderGLES3
|       |   \---2b651c285a02b7d4221af1827e1613c03e73e600ebc40b9e6a0b22bb855bd75f
|       |           0569298c4bd67f71fa194e93b48a113d8bfd63e0.cache
|       |
|       +---ParticlesCopyShaderGLES3
|       |   \---c778843b0cd1c7ce4c621fa2b924f703ac4001faef0555114b81a76c264a6908
|       +---ParticlesShaderGLES3
|       |   \---9bf432d37b0b4792d67aa9f577258845d4047e3f98e990aeca6fd20a868c4db2
|       +---SceneShaderGLES3
|       |   \---7757391c487ac94cfa6418166bd5fdacce470f09394c1a2a875e878c8c5d8596
|       |           0569298c4bd67f71fa194e93b48a113d8bfd63e0.cache
|       |           1f75832d84ea2128aac58e9975dab8cefa46561f.cache
|       |           4e002e62ef22dfdcf101da3b462c847e3241dd05.cache
|       |
|       +---SkeletonShaderGLES3
|       |   \---add3f03e6eebdffdf0073fae42195857307eddada333b82998642329511917a2
|       \---SkyShaderGLES3
|           \---1fe105946e63973aecf5198091930c2bdb17778012ef0253e325ade3a297e6c8
|                   33f4853c06988eac9a9ede63fa1ea0124debb133.cache
|
+---Nodes
|       Alert.tscn
|       Bakery.tscn
|       Building.tscn
|       Cell.tscn
|       EcologyGauge.tscn
|       EconomyGauge.tscn
|       End.tscn
|       EnergySupplier.tscn
|       Factory.tscn
|       Field.tscn
|       Gauge.tscn
|       Grass.tscn
|       Grid.tscn
|       Grocery.tscn
|       Impacts.tscn
|       Inventory.tscn
|       MainScene.tscn
|       PlacementList.tscn
|       RawNode.tscn
|       Round.tscn
|       Shaft.tscn
|       SocialGauge.tscn
|       Warehouse.tscn
|
+---Programs
|       Alert.cs
|       Bakery.cs
|       Building.cs
|       BuildingFactory.cs
|       Cell.cs
|       EcologyGauge.cs
|       EconomyGauge.cs
|       End.cs
|       EnergySupplier.cs
|       Factory.cs
|       Field.cs
|       FlowKind.cs
|       Gauge.cs
|       Grass.cs
|       Grid.cs
|       GridBuilder.cs
|       Grocery.cs
|       ICell.cs
|       ICellObserver.cs
|       ICellUsher.cs
|       IGauge.cs
|       IGrid.cs
|       IImpacts.cs
|       IInventory.cs
|       Impacts.cs
|       Inventory.cs
|       IPlaceMediator.cs
|       IRound.cs
|       MainScene.cs
|       PlaceMediator.cs
|       PlacementList.cs
|       RawNode.cs
|       Round.cs
|       Shaft.cs
|       SocialGauge.cs
|       Warehouse.cs
|
\---Ressources
    +---Font
    |       Born2bSportyV2.ttf
    |       Born2bSportyV2.ttf.import
    |
    \---Images
            alertbackground.png
            alertbackground.png.import
            bakery.png
            bakery.png.import
            complete_ecologygauge.png
            complete_ecologygauge.png.import
            complete_economygauge.png
            complete_economygauge.png.import
            complete_socialgauge.png
            complete_socialgauge.png.import
            const.png
            const.png.import
            cross.png
            cross.png.import
            default.png
            default.png.import
            down.png
            down.png.import
            down_.png
            down_.png.import
            emblem.png
            emblem.png.import
            empty_gauge.png
            empty_gauge.png.import
            energysupplier.png
            energysupplier.png.import
            factory.png
            factory.png.import
            fail.png
            fail.png.import
            field.png
            field.png.import
            grass.png
            grass.png.import
            grocery.png
            grocery.png.import
            Help.png
            Help.png.import
            HelpHover.png
            HelpHover.png.import
            house.png
            house.png.import
            inventory.png
            inventory.png.import
            inventorybutton.png
            inventorybutton.png.import
            leftclick.png
            leftclick.png.import
            metallurgy.png
            metallurgy.png.import
            next.png
            next.png.import
            sawmill.png
            sawmill.png.import
            shaft.png
            shaft.png.import
            up.png
            up.png.import
            victory.png
            victory.png.import
            warehouse.png
            warehouse.png.import
            willchange.png
            willchange.png.import
```

## Constitution du package comprenant les éléments essentiels tels que fichiers, répertoires, liens, périphériques, etc.
### Paramètres Généraux :
Il est impossible de modifier les paramètres de jeu sans toucher directement au code. 

### Identification claire de l'application, environnement cible (système d'exploitation spécifique, compatibilité avec différents systèmes, capacité à être exécutée sur serveur, etc.).
L'application est disponible pour Window et Linux uniquement. Elle ne peut nativement pas être exécutée sur un serveur.  

#### Notes IOS
Un éxecutable est générable pour mac via Godot engine. Merci de suivre les instructions disponibles dans la doc officielle Godot, à ce lien <https://docs.godotengine.org/en/stable/tutorials/export/exporting_for_ios.html>.

### Base de Données :
Aucune.

## Configuration des détails de connexion pour garantir l'accès aux données nécessaires, le cas échéant.
### Serveur Web :
Aucun nativement. 

_Les notes de cette section peuvent être ignorées et ne sont là qu'à but d'expliciter l'abscence de besoin particulier !

### Paramétrage des détails du serveur web, y compris les certificats SSL si requis.
#### Gestion des Logs, Emails et Erreurs :
#### Prise en compte de la gestion des fichiers logs, des e-mails et des erreurs pour assurer une maintenance aisée.

## Internationalisation :
Le jeu n'est disponible qu'en français (même s'il intègre quelques mots anglais).

Aucun paramètre de langue n'existe nativement.

## Intégration de Services Tiers :
Aucune intégration n'est nécessaire pour __executer__ l'application. 

Quant à son __développement__, il est nécessaire d'installer :
- Godot 4 C# ou supérieur   _(parfois nommé Godot Mono)_
- Dotnet 7.0.403    _(SDK)_
