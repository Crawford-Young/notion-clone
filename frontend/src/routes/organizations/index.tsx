import { createFileRoute, Link } from "@tanstack/react-router";
import { Button } from "@/components/ui/button";
import {
  Card,
  CardContent,
  CardDescription,
  CardHeader,
  CardTitle,
} from "@/components/ui/card";
import { Plus } from "lucide-react";

export const Route = createFileRoute("/organizations/")({
  component: OrganizationsPage,
});

function OrganizationsPage() {
  // TODO: Ticket #10 - Organization Dashboard
  // Implement organization list fetching
  // const { data: organizations, isLoading } = useOrganizations();

  const organizations = [
    { id: "1", name: "My Organization", memberCount: 5 },
    { id: "2", name: "Team Project", memberCount: 12 },
  ];

  return (
    <div className="container mx-auto p-6">
      <div className="flex items-center justify-between mb-6">
        <h1 className="text-3xl font-bold">Organizations</h1>
        <Button>
          <Plus className="w-4 h-4 mr-2" />
          Create Organization
        </Button>
      </div>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        {organizations.map((org) => (
          <Card key={org.id} className="hover:shadow-lg transition-shadow">
            <CardHeader>
              <CardTitle>{org.name}</CardTitle>
              <CardDescription>{org.memberCount} members</CardDescription>
            </CardHeader>
            <CardContent>
              <Button asChild className="w-full">
                <Link to={`/organizations/${org.id}`}>Open Organization</Link>
              </Button>
            </CardContent>
          </Card>
        ))}
      </div>

      {organizations.length === 0 && (
        <div className="text-center py-12">
          <h2 className="text-xl font-semibold mb-2">No organizations yet</h2>
          <p className="text-muted-foreground mb-4">
            Create your first organization to get started
          </p>
          <Button>
            <Plus className="w-4 h-4 mr-2" />
            Create Organization
          </Button>
        </div>
      )}
    </div>
  );
}

/* 
TODO: Ticket #10 - Organization Dashboard
- This file has the basic organization list structure
- Implement organization fetching from API
- Add organization creation functionality
- Add loading and error states
- Add organization deletion functionality
- Test organization navigation
*/
