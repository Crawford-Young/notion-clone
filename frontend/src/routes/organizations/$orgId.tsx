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

export const Route = createFileRoute("/organizations/$orgId")({
  component: OrganizationPage,
});

function OrganizationPage() {
  const { orgId } = Route.useParams();

  // TODO: Ticket #10 - Organization Dashboard
  // Implement organization and pages fetching
  // const { data: organization } = useOrganization(orgId);
  // const { data: pages } = usePages(orgId);

  const organization = { id: orgId, name: "My Organization" };
  const pages = [
    { id: "1", title: "Welcome Page", updatedAt: new Date() },
    { id: "2", title: "Project Notes", updatedAt: new Date() },
  ];

  return (
    <div className="container mx-auto p-6">
      <div className="flex items-center justify-between mb-6">
        <div>
          <h1 className="text-3xl font-bold">{organization.name}</h1>
          <p className="text-muted-foreground">Organization workspace</p>
        </div>
        <Button>
          <Plus className="w-4 h-4 mr-2" />
          Create Page
        </Button>
      </div>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        {pages.map((page) => (
          <Card key={page.id} className="hover:shadow-lg transition-shadow">
            <CardHeader>
              <CardTitle>{page.title}</CardTitle>
              <CardDescription>
                Updated {page.updatedAt.toLocaleDateString()}
              </CardDescription>
            </CardHeader>
            <CardContent>
              <Button asChild className="w-full">
                <Link to={`/organizations/${orgId}/pages/${page.id}`}>
                  Open Page
                </Link>
              </Button>
            </CardContent>
          </Card>
        ))}
      </div>

      {pages.length === 0 && (
        <div className="text-center py-12">
          <h2 className="text-xl font-semibold mb-2">No pages yet</h2>
          <p className="text-muted-foreground mb-4">
            Create your first page to get started
          </p>
          <Button>
            <Plus className="w-4 h-4 mr-2" />
            Create Page
          </Button>
        </div>
      )}
    </div>
  );
}

/* 
TODO: Ticket #10 - Organization Dashboard
- This file has the basic organization page structure
- Implement organization and pages fetching from API
- Add page creation functionality
- Add loading and error states
- Add page deletion functionality
- Test page navigation
*/
