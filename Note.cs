using System;
using System.Collections.Generic;

namespace PhoneBook
{
	public class Note : IEquatable<Note>
	{
		public string LastName;
		public string Name;
		public string Patronymic;
		public string Street;
		public ushort House;
		public ushort Flat;
		public string Phone;
		#region auto genearated
		public override bool Equals(object obj) => Equals(obj as Note);
		public bool Equals(Note other) =>
			other != null &&
			LastName == other.LastName &&
			Name == other.Name &&
			Patronymic == other.Patronymic &&
			Street == other.Street &&
			House == other.House &&
			Flat == other.Flat &&
			Phone == other.Phone;
		public override int GetHashCode()
		{
			int hashCode = -1239075987;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Patronymic);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
			hashCode = hashCode * -1521134295 + House.GetHashCode();
			hashCode = hashCode * -1521134295 + Flat.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
			return hashCode;
		}
		public static bool operator ==(Note left, Note right) =>
			EqualityComparer<Note>.Default.Equals(left, right);
		public static bool operator !=(Note left, Note right) =>
			!(left == right);
		#endregion
	}
}