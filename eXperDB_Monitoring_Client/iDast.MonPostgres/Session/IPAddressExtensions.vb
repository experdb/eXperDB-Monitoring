Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Net


Public Class SubnetMask
    Public Shared ReadOnly ClassA As IPAddress = IPAddress.Parse("255.0.0.0")
    Public Shared ReadOnly ClassB As IPAddress = IPAddress.Parse("255.255.0.0")
    Public Shared ReadOnly ClassC As IPAddress = IPAddress.Parse("255.255.255.0")

    Function CreateByHostBitLength(ByVal hostpartLength_P As Integer) As IPAddress
        Dim hostPartLength As Integer = hostpartLength_P
        Dim netPartLength As Integer = 32 - hostPartLength
        If netPartLength < 2 Then Throw New ArgumentException("Number of hosts is to large for IPv4")
        Dim binaryMask As Byte() = New Byte(3) {}

        For i As Integer = 0 To 4 - 1

            If i * 8 + 8 <= netPartLength Then
                binaryMask(i) = CByte(255)
            ElseIf i * 8 > netPartLength Then
                binaryMask(i) = CByte(0)
            Else
                Dim oneLength As Integer = netPartLength - i * 8
                Dim binaryDigit As String = String.Empty.PadLeft(oneLength, "1"c).PadRight(8, "0"c)
                binaryMask(i) = Convert.ToByte(binaryDigit, 2)
            End If
        Next

        Return New IPAddress(binaryMask)
    End Function

    Function CreateByNetBitLength(ByVal netpartLength As Integer) As IPAddress
        Dim hostPartLength As Integer = 32 - netpartLength
        Return CreateByHostBitLength(hostPartLength)
    End Function

    Function CreateByHostNumber(ByVal numberOfHosts As Integer) As IPAddress
        Dim maxNumber As Integer = numberOfHosts + 1
        Dim b As String = Convert.ToString(maxNumber, 2)
        Return CreateByHostBitLength(b.Length)
    End Function
End Class

Public Class IPAddressExtensions
    Public Function GetBroadcastAddress(ByVal address As IPAddress, ByVal subnetMask As IPAddress) As IPAddress
        Dim ipAdressBytes As Byte() = address.GetAddressBytes()
        Dim subnetMaskBytes As Byte() = subnetMask.GetAddressBytes()
        If ipAdressBytes.Length <> subnetMaskBytes.Length Then Throw New ArgumentException("Lengths of IP address and subnet mask do not match.")
        Dim broadcastAddress As Byte() = New Byte(ipAdressBytes.Length - 1) {}

        For i As Integer = 0 To broadcastAddress.Length - 1
            broadcastAddress(i) = CByte((ipAdressBytes(i) Or (subnetMaskBytes(i) Xor 255)))
        Next

        Return New IPAddress(broadcastAddress)
    End Function

    Public Function GetNetworkAddress(ByVal address As IPAddress, ByVal subnetMask As IPAddress) As IPAddress
        Dim ipAdressBytes As Byte() = address.GetAddressBytes()
        Dim subnetMaskBytes As Byte() = subnetMask.GetAddressBytes()
        If ipAdressBytes.Length <> subnetMaskBytes.Length Then Throw New ArgumentException("Lengths of IP address and subnet mask do not match.")
        Dim broadcastAddress As Byte() = New Byte(ipAdressBytes.Length - 1) {}

        For i As Integer = 0 To broadcastAddress.Length - 1
            broadcastAddress(i) = CByte((ipAdressBytes(i) And (subnetMaskBytes(i))))
        Next

        Return New IPAddress(broadcastAddress)
    End Function

    Public Function IsInSameSubnet(ByVal address2 As IPAddress, ByVal address As IPAddress, ByVal subnetMask As IPAddress) As Boolean
        'Dim network1 As IPAddress = address.GetNetworkAddress(subnetMask)
        'Dim network2 As IPAddress = address2.GetNetworkAddress(subnetMask)
        Dim network1 As IPAddress = GetNetworkAddress(address, subnetMask)
        Dim network2 As IPAddress = GetNetworkAddress(address2, subnetMask)
        Return network1.Equals(network2)
    End Function
End Class

