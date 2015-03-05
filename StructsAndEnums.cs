//
// StructsAndEnums.cs
//
// Author:
//       Philippe Creytens <philippe@bazookas.be>
//
// Copyright (c) 2015 Philippe Creytens
using System;

namespace StarIOBinding {

	public enum Emulation : uint {
		StarLineMode,
		ESCPOSMode
	}

	public enum _SMDeviceType : uint {
		SMDeviceTypeUnknown = 0,
		SMDeviceTypeDesktopPrinter,
		SMDeviceTypePortablePrinter,
		SMDeviceTypeDKAirCash
	}

	public enum _SMBluetoothSecurity : uint {
		SMBluetoothSecuritySSP,
		SMBluetoothSecurityPINcode
	}

	public enum _SecuritySetting : uint {
		PinCode,
		SSP
	}
}


