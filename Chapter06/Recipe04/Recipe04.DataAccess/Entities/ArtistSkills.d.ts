declare module server {
	interface artistSkill {
		artistSkillId: number;
		talentName: string;
		skillLevel: number;
		details: string;
		styles: string;
		artist: {
			artistId: number;
			userName: string;
			country: string;
			provence: string;
			city: string;
			createDate: Date;
			artistSkills: any[];
		};
	}
}
