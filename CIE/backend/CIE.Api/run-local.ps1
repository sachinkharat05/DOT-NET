$ErrorActionPreference = 'Stop'

$projectPath = Join-Path $PSScriptRoot 'CIE.Api.csproj'
$previousConnection = $env:ConnectionStrings__CieDatabase
$securePassword = Read-Host 'MySQL root password' -AsSecureString
$passwordPointer = [IntPtr]::Zero

try {
    $passwordPointer = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($securePassword)
    $password = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($passwordPointer)

    $connection = [System.Data.Common.DbConnectionStringBuilder]::new()
    $connection['Server'] = 'localhost'
    $connection['Port'] = 3306
    $connection['Database'] = 'cie_db'
    $connection['User ID'] = 'root'
    $connection['Password'] = $password
    $env:ConnectionStrings__CieDatabase = $connection.ConnectionString

    dotnet run --project $projectPath --launch-profile http
    if ($LASTEXITCODE -ne 0) {
        exit $LASTEXITCODE
    }
}
finally {
    if ($null -eq $previousConnection) {
        Remove-Item Env:\ConnectionStrings__CieDatabase -ErrorAction SilentlyContinue
    }
    else {
        $env:ConnectionStrings__CieDatabase = $previousConnection
    }

    if ($passwordPointer -ne [IntPtr]::Zero) {
        [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($passwordPointer)
    }
    $password = $null
    $securePassword.Dispose()
}
